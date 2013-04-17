#region License

/*
PortableDevice.cs
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
using System.ComponentModel;
using System.Linq;
using PortableDeviceApiLib;
using PortableDeviceLib.Factories;
using PortableDeviceLib.Model;
using PortableDeviceTypesLib;
using IPortableDeviceKeyCollection = PortableDeviceApiLib.IPortableDeviceKeyCollection;
using IPortableDeviceValues = PortableDeviceApiLib.IPortableDeviceValues;
using _tagpropertykey = PortableDeviceApiLib._tagpropertykey;

namespace PortableDeviceLib
{
    /// <summary>
    ///     Represent a portable device
    /// </summary>
    public class PortableDevice : IDisposable, INotifyPropertyChanged
    {
        private readonly object dispatcher; //Use an object for thread safety
        private const string DEVICE = "DEVICE";

        private string adviseCookie;
        private PortableDeviceEventCallback eventCallback;
        private Dictionary<string, object> values;
        private PropertiesHelper propertiesHelper;

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        /// <param name="deviceId"></param>
        internal PortableDevice(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId))
                throw new ArgumentNullException("deviceId");
            dispatcher = new object();
            PortableDeviceClass = new PortableDeviceClass();
            values = new Dictionary<string, object>();
            DeviceId = deviceId;
            propertiesHelper = new PropertiesHelper(this);
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the device ID
        /// </summary>
        public string DeviceId { get; private set; }

        /// <summary>
        ///     Gets a value
        /// </summary>
        public bool IsConnected { get; private set; }

        /// <summary>
        ///     Gets the Friendly name of the device
        /// </summary>
        public string FriendlyName
        {
            get { return propertiesHelper.GetStringProperty(DEVICE, PortableDevicePKeys.WPD_DEVICE_FRIENDLY_NAME); }
        }

        /// <summary>
        ///     Gets the battery level of the device
        /// </summary>
        public int BatteryLevel
        {
            get { return propertiesHelper.GetIntegerProperty(DEVICE, PortableDevicePKeys.WPD_DEVICE_POWER_LEVEL); }
        }

        /// <summary>
        ///     Gets the device model
        /// </summary>
        public string Model
        {
            get { return propertiesHelper.GetStringProperty(DEVICE, PortableDevicePKeys.WPD_DEVICE_MODEL); }
        }

        /// <summary>
        ///     Gets the firmware version
        /// </summary>
        public string FirmwareVersion
        {
            get { return propertiesHelper.GetStringProperty(DEVICE, PortableDevicePKeys.WPD_DEVICE_FIRMWARE_VERSION); }
        }

        /// <summary>
        ///     Gets the serial number of device
        /// </summary>
        public string SerialNumber
        {
            get { return propertiesHelper.GetStringProperty(DEVICE, PortableDevicePKeys.WPD_DEVICE_SERIAL_NUMBER); }
        }

        /// <summary>
        ///     Gets the device type
        /// </summary>
        public string DeviceType
        {
            get { return propertiesHelper.GetStringProperty(DEVICE, PortableDevicePKeys.WPD_DEVICE_TYPE); }
        }

        /// <summary>
        ///     Gets the capabilities of the device
        /// </summary>
        public PortableDeviceCapabilities DeviceCapabilities { get; private set; }

        /// <summary>
        ///     Gets all content from device
        ///     If return is null be sure you call <see cref="PortableDevice.RefreshContent()" /> before
        /// </summary>
        public PortableDeviceFunctionalObject Content { get; private set; }

        internal PortableDeviceClass PortableDeviceClass { get; private set; }

        #endregion

        #region Public functions

        /// <summary>
        ///     Dispose the unmanaged resource
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Connect to the portable device
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="majorVersionNumber"></param>
        /// <param name="minorVersionNumber"></param>
        public void ConnectToDevice(string appName, float majorVersionNumber, float minorVersionNumber)
        {
            if (string.IsNullOrEmpty(appName))
                throw new ArgumentNullException("appName");

            //Creating propValues for connection
            var clientValues = (IPortableDeviceValues) new PortableDeviceValuesClass();

            //Set the application name
            _tagpropertykey prop = PortableDevicePKeys.WPD_CLIENT_NAME;
            clientValues.SetStringValue(ref prop, appName);
            //Set the App version
            prop = PortableDevicePKeys.WPD_CLIENT_MAJOR_VERSION;
            clientValues.SetFloatValue(ref prop, majorVersionNumber);
            //Set the app minor version
            prop = PortableDevicePKeys.WPD_CLIENT_MINOR_VERSION;
            clientValues.SetFloatValue(ref prop, minorVersionNumber);

            //Open connection
            PortableDeviceClass.Open(DeviceId, clientValues);

            //Extract device capabilities
            ExtractDeviceCapabilities();

            eventCallback = new PortableDeviceEventCallback(this);
            // According to documentation pParameters should be null (see http://msdn.microsoft.com/en-us/library/dd375684%28v=VS.85%29.aspx )
            PortableDeviceClass.Advise(0, eventCallback, null, out adviseCookie);

            IsConnected = true;
        }

        /// <summary>
        ///     Disconnect from device
        /// </summary>
        public void Disconnect()
        {
            if (!IsConnected)
                return;

            PortableDeviceClass.Unadvise(adviseCookie);
            eventCallback = null;
            IsConnected = false;
        }

        /// <summary>
        ///     Refresh content from device
        /// </summary>
        public void RefreshContent()
        {
            StartEnumerate();
        }

        /// <summary>
        ///     Execute the specified command
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(_tagpropertykey command)
        {
            var commandValues = (IPortableDeviceValues) new PortableDeviceValuesClass();
            IPortableDeviceValues results;

            commandValues.SetGuidValue(ref PortableDevicePKeys.WPD_PROPERTY_COMMON_COMMAND_CATEGORY, ref command.fmtid);
            commandValues.SetUnsignedIntegerValue(ref PortableDevicePKeys.WPD_PROPERTY_COMMON_COMMAND_ID, command.pid);

            // According to documentation, first parameter should be 0 (see http://msdn.microsoft.com/en-us/library/dd375691%28v=VS.85%29.aspx)
            PortableDeviceClass.SendCommand(0, commandValues, out results);
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return IsConnected ? FriendlyName : DeviceId;
        }

        #endregion

        #region Protected functions

        /// <summary>
        ///     Raise the <see cref="PropertyChanged" /> event
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Internal functions

        /// <summary>
        ///     Raise event from device
        /// </summary>
        internal void RaiseEvent(PortableDeviceEventType eventType)
        {
            if (DeviceEvent != null)
            {
                DeviceEvent(this, new PortableDeviceEventArgs(eventType));
            }
        }

        #endregion

        #region Private functions

        private void ExtractDeviceCapabilities()
        {
            DeviceCapabilities = new PortableDeviceCapabilities();
            DeviceCapabilities.ExtractDeviceCapabilities(PortableDeviceClass);
            DeviceCapabilities.ExtractCommands(PortableDeviceClass);
            DeviceCapabilities.ExtractEvents(PortableDeviceClass);
        }

        private void StartEnumerate()
        {
            lock (dispatcher)
            {
                IPortableDeviceContent pContent;
                PortableDeviceClass.Content(out pContent);

                Content = new PortableDeviceFunctionalObject("DEVICE");
                Enumerate(ref pContent, "DEVICE", Content);

                RaisePropertyChanged("Content");
            }
        }

        internal void Enumerate(ref IPortableDeviceContent pContent, string parentID, PortableDeviceContainerObject node, bool detectNewObjects = false)
        {
            IPortableDeviceProperties properties;
            pContent.Properties(out properties);

            IEnumPortableDeviceObjectIDs pEnum;
            pContent.EnumObjects(0, parentID, null, out pEnum);

            uint cFetched = 0;
            do
            {
                string objectID;
                pEnum.Next(1, out objectID, ref cFetched);

                if (cFetched <= 0) continue;

                if (detectNewObjects)
                {
                    var q = from child in node.Childs
                            where child.ID == objectID
                            select child;
                    if (q.Any()) continue;
                }

                PortableDeviceObject current = ExtractInformation(properties, objectID);
                node.AddChild(current);
                if (current is PortableDeviceContainerObject)
                    Enumerate(ref pContent, objectID, (PortableDeviceContainerObject) current);
            } while (cFetched > 0);
        }

        private PortableDeviceObject ExtractInformation(IPortableDeviceProperties properties, string objectId)
        {
            IPortableDeviceKeyCollection keys;
            properties.GetSupportedProperties(objectId, out keys);

            IPortableDeviceValues values;
            properties.GetValues(objectId, keys, out values);

            Guid guid;
            values.GetGuidValue(ref PortableDevicePKeys.WPD_OBJECT_CONTENT_TYPE, out guid);

            return PortableDeviceObjectFactory.Instance.CreateInstance(guid, values);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!string.IsNullOrEmpty(adviseCookie))
                    PortableDeviceClass.Unadvise(adviseCookie);

                if (IsConnected)
                    PortableDeviceClass.Close();
            }

            PortableDeviceClass = null;
        }

        /// <summary>
        ///     Finalizer
        /// </summary>
        ~PortableDevice()
        {
            Dispose(false);
        }

        #endregion

        /// <summary>
        ///     <see cref="System.ComponentModel.INotifyPropertyChanged" />
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Event sended when portable device raise an event
        /// </summary>
        public event EventHandler<PortableDeviceEventArgs> DeviceEvent;
    }
}