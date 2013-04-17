using System;
using PortableDeviceApiLib;
using PortableDeviceLib.Model;
using PortableDeviceTypesLib;
using IPortableDeviceValues = PortableDeviceApiLib.IPortableDeviceValues;
using _tagpropertykey = PortableDeviceApiLib._tagpropertykey;

namespace PortableDeviceLib
{
    internal class PropertiesHelper
    {
        private readonly PortableDevice device;

        public PropertiesHelper(PortableDevice device)
        {
            this.device = device;
        }

        private IPortableDeviceProperties GetProperties()
        {
            //Ensure we are connected to device
            CheckIfIsConnected();

            IPortableDeviceContent content;
            IPortableDeviceProperties properties;

            device.PortableDeviceClass.Content(out content);
            content.Properties(out properties);

            return properties;
        }

        public IPortableDeviceValues GetPropertyAttributes(string objectId, _tagpropertykey propertyKey)
        {
            IPortableDeviceValues attributes;
            GetProperties().GetPropertyAttributes(objectId, ref propertyKey, out attributes);
            return attributes;
        }

        public T GetProperty<T>(string objectId, Func<IPortableDeviceValues, T> extractor)
        {
            IPortableDeviceValues propertyValues;
            GetProperties().GetValues(objectId, null, out propertyValues);

            return extractor(propertyValues);
        }

        public string GetStringProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, deviceValues =>
                {
                    string val;
                    deviceValues.GetStringValue(ref propertyKey, out val);
                    return val;
                });
        }

        public int GetIntegerProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, deviceValues =>
                {
                    int val;
                    deviceValues.GetSignedIntegerValue(ref propertyKey, out val);
                    return val;
                });
        }

        public bool GetBooleanProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, deviceValues =>
                {
                    int val;
                    deviceValues.GetBoolValue(ref propertyKey, out val);
                    return val == 1;
                });
        }

        public Guid GetGuidProperty(string objectId, _tagpropertykey propertyKey)
        {
            return GetProperty(objectId, deviceValues =>
                {
                    Guid val;
                    deviceValues.GetGuidValue(ref propertyKey, out val);
                    return val;
                });
        }

        public void SetProperty(string objectId, _tagpropertykey propertyKey, Action<IPortableDeviceValues> setValues)
        {
            int canWrite;
            GetPropertyAttributes(objectId, propertyKey).GetBoolValue(PortableDevicePKeys.WPD_PROPERTY_ATTRIBUTE_CAN_WRITE, out canWrite);

            if (canWrite == 0)
                throw new Exception("Property cannot be changed/updated");

            var values = (IPortableDeviceValues) new PortableDeviceValuesClass();

            setValues(values);

            IPortableDeviceValues result;
            GetProperties().SetValues(objectId, values, out result);
        }

        public void SetStringProperty(string objectId, _tagpropertykey propertyKey, string value)
        {
            SetProperty(objectId, propertyKey, values => values.SetStringValue(propertyKey, value));
        }

        public void SetIntProperty(string objectId, _tagpropertykey propertyKey, int value)
        {
            SetProperty(objectId, propertyKey, values => values.SetSignedIntegerValue(propertyKey, value));
        }

        public void SetBoolProperty(string objectId, _tagpropertykey propertyKey, bool value)
        {
            SetProperty(objectId, propertyKey, values => values.SetBoolValue(propertyKey, value ? 1 : 0));
        }

        public void SetGuidProperty(string objectId, _tagpropertykey propertyKey, Guid value)
        {
            SetProperty(objectId, propertyKey, values => values.SetGuidValue(propertyKey, value));
        }

        private void CheckIfIsConnected()
        {
            if (!device.IsConnected)
                throw new Exception("Not connected");
        }
    }
}