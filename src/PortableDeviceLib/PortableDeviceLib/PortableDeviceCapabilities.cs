#region License

/*
PortableDeviceCapabilities.cs
Copyright (C) 2009 Vincent Lainé
 
This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using PortableDeviceApiLib;
using PortableDeviceLib.Model;
using PortableDeviceTypesLib;
using IPortableDeviceKeyCollection = PortableDeviceApiLib.IPortableDeviceKeyCollection;
using IPortableDevicePropVariantCollection = PortableDeviceApiLib.IPortableDevicePropVariantCollection;
using IPortableDeviceValues = PortableDeviceApiLib.IPortableDeviceValues;
using _tagpropertykey = PortableDeviceApiLib._tagpropertykey;
using tag_inner_PROPVARIANT = PortableDeviceApiLib.tag_inner_PROPVARIANT;

namespace PortableDeviceLib
{
    /// <summary>
    ///     Represent the device capabilities
    /// </summary>
    public class PortableDeviceCapabilities
    {
        private readonly Dictionary<string, _tagpropertykey> commands;
        private readonly Dictionary<PortableDeviceEventDescription, _tagpropertykey> events;
        private readonly Dictionary<Guid, FunctionalCategory> functionalCategories;

        /// <summary>
        ///     Default constructor
        /// </summary>
        internal PortableDeviceCapabilities()
        {
            functionalCategories = new Dictionary<Guid, FunctionalCategory>();
            commands = new Dictionary<string, _tagpropertykey>();
            events = new Dictionary<PortableDeviceEventDescription, _tagpropertykey>();
        }

        /// <summary>
        ///     Gets all functional categories
        /// </summary>
        public IEnumerable<FunctionalCategory> FunctionalCategories
        {
            get { return functionalCategories.Values; }
        }

        /// <summary>
        ///     Gets commands from devices
        /// </summary>
        public IEnumerable<string> Commands
        {
            get { return commands.Keys; }
        }

        /// <summary>
        ///     Gets supported events
        /// </summary>
        public IEnumerable<PortableDeviceEventDescription> Events
        {
            get { return events.Keys; }
        }

        /// <summary>
        ///     Extract device capabilities
        /// </summary>
        /// <param name="portableDeviceClass"></param>
        internal void ExtractDeviceCapabilities(PortableDeviceClass portableDeviceClass)
        {
            if (portableDeviceClass == null)
                throw new ArgumentNullException("portableDeviceClass");

            try
            {
                IPortableDeviceCapabilities capabilities;
                portableDeviceClass.Capabilities(out capabilities);

                if (capabilities == null)
                {
                    Trace.WriteLine("Cannot extract capabilities from device");
                    throw new PortableDeviceException("Cannot extract capabilities from device");
                }

                IPortableDevicePropVariantCollection functionalCategories;
                capabilities.GetFunctionalCategories(out functionalCategories);

                if (functionalCategories == null)
                {
                    throw new PortableDeviceException("Failed to extract functionnal categories");
                }

                uint countCategories = 1;
                functionalCategories.GetCount(ref countCategories);
                var values = new tag_inner_PROPVARIANT();

                string categoryName;
                Guid currentGuid;
                for (uint i = 0; i < countCategories; i++)
                {
                    functionalCategories.GetAt(i, ref values);
                    var pValues = (IPortableDeviceValues) new PortableDeviceValuesClass();

                    pValues.SetValue(ref PortableDevicePKeys.WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES, ref values);
                    pValues.GetStringValue(ref PortableDevicePKeys.WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES, out categoryName);
                    currentGuid = new Guid(categoryName);
                    this.functionalCategories.Add(currentGuid, new FunctionalCategory(
                                                                   portableDeviceClass,
                                                                   currentGuid,
                                                                   PortableDeviceHelpers.GetKeyNameFromGuid(currentGuid)));
                }
            }
            catch (Exception ex)
            {
                throw new PortableDeviceException("Error on extract device capabilities", ex);
            }
        }

        /// <summary>
        ///     Extract command supported by device
        /// </summary>
        /// <param name="portableDeviceClass"></param>
        internal void ExtractCommands(PortableDeviceClass portableDeviceClass)
        {
            IPortableDeviceCapabilities capabilities;
            portableDeviceClass.Capabilities(out capabilities);

            IPortableDeviceKeyCollection values;
            capabilities.GetSupportedCommands(out values);

            var key = new _tagpropertykey();
            _tagpropertykey tt;
            string currentName;

            uint count = 1;
            values.GetCount(ref count);
            for (uint i = 0; i < count; i++)
            {
                values.GetAt(i, ref key);

                currentName = string.Empty;
                foreach (FieldInfo fi in typeof (PortableDevicePKeys).GetFields())
                {
                    tt = (_tagpropertykey) fi.GetValue(null);
                    if (key.fmtid == tt.fmtid && key.pid == tt.pid)
                        currentName = fi.Name;
                }

                if (!string.IsNullOrEmpty(currentName))
                    commands.Add(currentName, key);
                else
                    commands.Add(key.pid + " " + key.fmtid, key);
            }
        }

        /// <summary>
        ///     Extract event supported by device
        /// </summary>
        /// <param name="portableDeviceClass"></param>
        internal void ExtractEvents(PortableDeviceClass portableDeviceClass)
        {
            IPortableDeviceCapabilities capabilities;
            portableDeviceClass.Capabilities(out capabilities);

            IPortableDevicePropVariantCollection events;
            capabilities.GetSupportedEvents(out events);

            uint countEvents = 0;
            events.GetCount(ref countEvents);

            var pValues = (IPortableDeviceValues) new PortableDeviceValuesClass();
            var evt = new tag_inner_PROPVARIANT();

            Guid eventName;
            IPortableDeviceValues eventOptions;
            PortableDeviceEventDescription eventDescription;

            for (uint i = 0; i < countEvents; i++)
            {
                events.GetAt(i, ref evt);
                pValues.SetValue(ref PortableDevicePKeys.WPD_EVENT_PARAMETER_EVENT_ID, ref evt);
                pValues.GetGuidValue(ref PortableDevicePKeys.WPD_EVENT_PARAMETER_EVENT_ID, out eventName);

                eventDescription = new PortableDeviceEventDescription(eventName, PortableDeviceHelpers.GetKeyNameFromGuid(eventName));

                //Retrieve options
                try
                {
                    // Event option isn't always present, so ...
                    eventOptions = (IPortableDeviceValues) new PortableDeviceValuesClass();
                    capabilities.GetEventOptions(ref eventName, out eventOptions);


                    //eventOptions.GetBoolValue(ref PortableDevicePKeys.WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT, out isAutoPlayEvent);
                    //eventOptions.GetBoolValue(ref PortableDevicePKeys.WPD_EVENT_OPTION_IS_BROADCAST_EVENT, out isBroadcastEvent);

                    //eventDescription.AddOptions(new PortableDeviceEventOption()
                    //{
                    //    Guid = PortableDevicePKeys.WPD_EVENT_OPTION_IS_BROADCAST_EVENT.fmtid,
                    //    Name = PortableDeviceHelpers.GetKeyNameFromGuid(PortableDevicePKeys.WPD_EVENT_OPTION_IS_BROADCAST_EVENT.fmtid),
                    //    Value = isBroadcastEvent,
                    //    ValueType = TypeCode.Boolean
                    //});

                    //eventDescription.AddOptions(new PortableDeviceEventOption()
                    //{
                    //    Guid = PortableDevicePKeys.WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT.fmtid,
                    //    Name = PortableDeviceHelpers.GetKeyNameFromGuid(PortableDevicePKeys.WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT.fmtid),
                    //    Value = isAutoPlayEvent,
                    //    ValueType = TypeCode.Boolean
                    //});
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                }

                this.events.Add(eventDescription, PortableDevicePKeys.WPD_EVENT_PARAMETER_EVENT_ID);
            }
        }
    }
}