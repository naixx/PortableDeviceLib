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
using System.Linq;
using System.Text;
using PortableDeviceApiLib;
using System.Runtime.InteropServices;
using PortableDeviceLib.Model;
using System.ComponentModel;

namespace PortableDeviceLib
{
    /// <summary>
    /// Represent a portable device
    /// </summary>
    public class PortableDevice : IDisposable, INotifyPropertyChanged
    {
        /// <summary>
        /// Event sended when portable device raise an event
        /// </summary>
        public event EventHandler<PortableDeviceEventArgs> DeviceEvent;

        /// <summary>
        /// <see cref="System.ComponentModel.INotifyPropertyChanged"/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private object dispatcher; //Use an object for thread safety

        private PortableDeviceApiLib.PortableDeviceClass portableDeviceClass;
        private Dictionary<string, object> values;
        private PortableDeviceCapabilities deviceCapabilities;
        private PortableDeviceFunctionalObject content;

        private string adviseCookie;
        private PortableDeviceEventCallback eventCallback;

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="deviceId"></param>
        internal PortableDevice(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId))
                throw new ArgumentNullException("deviceId");
            this.dispatcher = new object();
            this.portableDeviceClass = new PortableDeviceApiLib.PortableDeviceClass();
            this.values = new Dictionary<string, object>();

            this.DeviceId = deviceId;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the device ID
        /// </summary>
        public string DeviceId
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value 
        /// </summary>
        public bool IsConnected
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the Friendly name of the device
        /// </summary>
        public string FriendlyName
        {
            get
            {
                return GetStringProperty(PortableDevicePKeys.WPD_DEVICE_FRIENDLY_NAME);
            }
        }

        /// <summary>
        /// Gets the battery level of the device
        /// </summary>
        public int BatteryLevel
        {
            get
            {
                return GetIntegerProperty(PortableDevicePKeys.WPD_DEVICE_POWER_LEVEL);
            }
        }

        /// <summary>
        /// Gets the device model
        /// </summary>
        public string Model
        {
            get
            {
                return GetStringProperty(PortableDevicePKeys.WPD_DEVICE_MODEL);
            }
        }

        /// <summary>
        /// Gets the firmware version
        /// </summary>
        public string FirmwareVersion
        {
            get
            {
                return GetStringProperty(PortableDevicePKeys.WPD_DEVICE_FIRMWARE_VERSION);
            }
        }

        /// <summary>
        /// Gets the serial number of device
        /// </summary>
        public string SerialNumber
        {
            get
            {
                return GetStringProperty(PortableDevicePKeys.WPD_DEVICE_SERIAL_NUMBER);
            }
        }

        /// <summary>
        /// Gets the device type
        /// </summary>
        public string DeviceType
        {
            get
            {
                return this.GetStringProperty(PortableDevicePKeys.WPD_DEVICE_TYPE);
            }
        }

        /// <summary>
        /// Gets the capabilities of the device
        /// </summary>
        public PortableDeviceCapabilities DeviceCapabilities
        {
            get
            {
                return deviceCapabilities;
            }
        }

        /// <summary>
        /// Gets all content from device
        /// If return is null be sure you call <see cref="PortableDevice.RefreshContent()"/> before
        /// </summary>
        public PortableDeviceFunctionalObject Content
        {
            get
            {
                return content;
            }
        }

        #endregion

        #region Public functions

        /// <summary>
        /// Connect to the portable device
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="majorVersionNumber"></param>
        /// <param name="minorVersionNumber"></param>
        public void ConnectToDevice(string appName, float majorVersionNumber, float minorVersionNumber)
        {
            if (string.IsNullOrEmpty(appName))
                throw new ArgumentNullException("appName");

            //Creating propValues for connection
            IPortableDeviceValues clientValues = (IPortableDeviceValues)new PortableDeviceTypesLib.PortableDeviceValuesClass();

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
            this.portableDeviceClass.Open(this.DeviceId, clientValues);

            //Extract device capabilities
            this.ExtractDeviceCapabilities();

            this.eventCallback = new PortableDeviceEventCallback(this);
            // According to documentation pParameters should be null (see http://msdn.microsoft.com/en-us/library/dd375684%28v=VS.85%29.aspx )
            this.portableDeviceClass.Advise(0, this.eventCallback, null, out this.adviseCookie);

            IsConnected = true;
        }

        /// <summary>
        /// Disconnect from device
        /// </summary>
        public void Disconnect()
        {
            if (!this.IsConnected)
                return;

            this.portableDeviceClass.Unadvise(this.adviseCookie);
            this.eventCallback = null;
            this.IsConnected = false;
        }

        /// <summary>
        /// Refresh content from device
        /// </summary>
        public void RefreshContent()
        {
            this.StartEnumerate();
        }

        /// <summary>
        /// Execute the specified command
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(_tagpropertykey command)
        {
            IPortableDeviceValues commandValues = (IPortableDeviceValues)new PortableDeviceTypesLib.PortableDeviceValuesClass();
            IPortableDeviceValues results;

            commandValues.SetGuidValue(ref PortableDevicePKeys.WPD_PROPERTY_COMMON_COMMAND_CATEGORY, ref command.fmtid);
            commandValues.SetUnsignedIntegerValue(ref PortableDevicePKeys.WPD_PROPERTY_COMMON_COMMAND_ID, command.pid);

            // According to documentation, first parameter should be 0 (see http://msdn.microsoft.com/en-us/library/dd375691%28v=VS.85%29.aspx)
            this.portableDeviceClass.SendCommand(0, commandValues, out results);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (IsConnected)
                return FriendlyName;
            else
                return DeviceId;
        }

        /// <summary>
        /// Dispose the unmanaged resource
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Protected functions

        /// <summary>
        /// Raise the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Internal functions

        /// <summary>
        /// Raise event from device
        /// </summary>
        internal void RaiseEvent(PortableDeviceEventType eventType)
        {
            if (this.DeviceEvent != null)
            {
                this.DeviceEvent(this, new PortableDeviceEventArgs(eventType));
            }
        }

        #endregion

        #region Private functions

        private string GetStringProperty(_tagpropertykey propertyKey)
        {
            //Ensure we are connected to device
            CheckIfIsConnected();

            IPortableDeviceContent content;
            IPortableDeviceProperties properties;
            PortableDeviceApiLib.IPortableDeviceValues propertyValues;

            this.portableDeviceClass.Content(out content);
            content.Properties(out properties);

            properties.GetValues("DEVICE", null, out propertyValues);

            string val = string.Empty;
            propertyValues.GetStringValue(ref propertyKey, out val);

            return val;
        }

        private int GetIntegerProperty(_tagpropertykey propertyKey)
        {
            //Ensure we are connected to device
            CheckIfIsConnected();

            IPortableDeviceContent content;
            IPortableDeviceProperties properties;
            PortableDeviceApiLib.IPortableDeviceValues propertyValues;

            this.portableDeviceClass.Content(out content);
            content.Properties(out properties);
            properties.GetValues("DEVICE", null, out propertyValues);

            float val = -1;
            propertyValues.GetFloatValue(ref propertyKey, out val);
            return Convert.ToInt32(val);
        }

        private void CheckIfIsConnected()
        {
            if (!IsConnected)
                throw new Exception("Not connected");
        }

        private void ExtractDeviceCapabilities()
        {
            deviceCapabilities = new PortableDeviceCapabilities();
            deviceCapabilities.ExtractDeviceCapabilities(this.portableDeviceClass);
            deviceCapabilities.ExtractCommands(this.portableDeviceClass);
            deviceCapabilities.ExtractEvents(this.portableDeviceClass);
        }

        private void StartEnumerate()
        {
            lock (this.dispatcher)
            {

                PortableDeviceApiLib.IPortableDeviceContent pContent;
                this.portableDeviceClass.Content(out pContent);

                this.content = new PortableDeviceFunctionalObject("DEVICE");
                Enumerate(ref pContent, "DEVICE", this.content);

                this.RaisePropertyChanged("Content");
            }
        }

        private void Enumerate(ref PortableDeviceApiLib.IPortableDeviceContent pContent, string parentID, PortableDeviceContainerObject node)
        {
            PortableDeviceApiLib.IPortableDeviceProperties properties;
            pContent.Properties(out properties);

            PortableDeviceApiLib.IEnumPortableDeviceObjectIDs pEnum;
            pContent.EnumObjects(0, parentID, null, out pEnum);

            uint cFetched = 0;
            PortableDeviceObject current;
            do
            {
                string objectID;
                pEnum.Next(1, out objectID, ref cFetched);

                if (cFetched > 0)
                {
                    current = this.ExtractInformation(properties, objectID);
                    node.AddChild(current);
                    if (current is PortableDeviceContainerObject)
                        Enumerate(ref pContent, objectID, (PortableDeviceContainerObject)current);
                }

            } while (cFetched > 0);
        }

        private PortableDeviceObject ExtractInformation(PortableDeviceApiLib.IPortableDeviceProperties properties, string objectId)
        {
            PortableDeviceApiLib.IPortableDeviceKeyCollection keys;
            properties.GetSupportedProperties(objectId, out keys);

            PortableDeviceApiLib.IPortableDeviceValues values;
            properties.GetValues(objectId, keys, out values);

            string tmpVal;
            string name;
            values.GetStringValue(ref PortableDevicePKeys.WPD_OBJECT_NAME, out name);

            values.GetStringValue(ref PortableDevicePKeys.WPD_OBJECT_CONTENT_TYPE, out tmpVal);
            var guid = new Guid(tmpVal);
            string contentType = PortableDeviceHelpers.GetKeyNameFromGuid(guid);

            values.GetStringValue(ref PortableDevicePKeys.WPD_OBJECT_FORMAT, out tmpVal);
            string formatType = PortableDeviceHelpers.GetKeyNameFromGuid(new Guid(tmpVal));

            return Factories.PortableDeviceObjectFactory.Instance.CreateInstance(guid, objectId, name, contentType, formatType);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!string.IsNullOrEmpty(this.adviseCookie))
                    this.portableDeviceClass.Unadvise(this.adviseCookie);

                if (this.IsConnected)
                    this.portableDeviceClass.Close();
            }

            this.portableDeviceClass = null;
        }

        /// <summary>
        /// Finalizer
        /// </summary>
        ~PortableDevice()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
