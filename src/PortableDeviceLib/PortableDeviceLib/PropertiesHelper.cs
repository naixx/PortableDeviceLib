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

        public T GetProperty<T>(string objectId, _tagpropertykey propertyKey, Func<IPortableDeviceValues, T> extractor)
        {
            //Ensure we are connected to device
            CheckIfIsConnected();

            IPortableDeviceContent content;
            IPortableDeviceProperties properties;
            IPortableDeviceValues propertyValues;

            device.PortableDeviceClass.Content(out content);
            content.Properties(out properties);

            properties.GetValues(objectId, null, out propertyValues);

            return extractor(propertyValues);
        }

        public T GetProperty<T>(PortableDeviceObject obj, _tagpropertykey propertyKey, Func<IPortableDeviceValues, T> extractor)
        {
            return GetProperty(obj.ID, propertyKey, extractor);
        }

        public string GetStringProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, propertyKey, deviceValues =>
                {
                    string val;
                    deviceValues.GetStringValue(ref propertyKey, out val);
                    return val;
                });
        }

        public int GetIntegerProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, propertyKey, deviceValues =>
                {
                    int val;
                    deviceValues.GetSignedIntegerValue(ref propertyKey, out val);
                    return val;
                });
        }

        public bool GetBooleanProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, propertyKey, deviceValues =>
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