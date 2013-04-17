using System;
using PortableDeviceApiLib;
using PortableDeviceLib.Model;

namespace PortableDeviceLib
{
    internal class PropertiesHelper
    {
        private readonly PortableDevice device;

        public PropertiesHelper(PortableDevice device)
        {
            this.device = device;
        }

        public IPortableDeviceProperties GetProperties()
        {
            //Ensure we are connected to device
            CheckIfIsConnected();

            IPortableDeviceContent content;
            IPortableDeviceProperties properties;

            device.PortableDeviceClass.Content(out content);
            content.Properties(out properties);
            
            return properties;
        }

        private T GetPropertyValues<T>(string objectId, Func<IPortableDeviceValues, T> extractor)
        {
            IPortableDeviceValues propertyValues;
            GetProperties().GetValues(objectId, null, out propertyValues);

            return extractor(propertyValues);
        }

        public string GetStringProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetPropertyValues(objectId, deviceValues =>
                {
                    string val;
                    deviceValues.GetStringValue(ref propertyKey, out val);
                    return val;
                });
        }

        public int GetIntegerProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetPropertyValues(objectId, deviceValues =>
                {
                    int val;
                    deviceValues.GetSignedIntegerValue(ref propertyKey, out val);
                    return val;
                });
        }

        public bool GetBooleanProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetPropertyValues(objectId, deviceValues =>
                {
                    int val;
                    deviceValues.GetBoolValue(ref propertyKey, out val);
                    return val == 1;
                });
        }

        private void CheckIfIsConnected()
        {
            if (!device.IsConnected)
                throw new Exception("Not connected");
        }
    }
}