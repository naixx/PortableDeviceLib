using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortableDeviceLib.Model;

namespace PortableDeviceLib.Factories
{
    /// <summary>
    /// Represent a factory that can build <see cref="PortableDeviceObject"/>
    /// You can register new method to handle new object types
    /// </summary>
    public class PortableDeviceObjectFactory
    {
        public delegate PortableDeviceObject FactoryMethodType(PortableDeviceApiLib.IPortableDeviceValues values);
        private static PortableDeviceObjectFactory instance;
        private Dictionary<Guid, FactoryMethodType> factoryMethods;

        /// <summary>
        /// Initialize a new instance of the <see cref="PortableDeviceObjectFactory"/> class
        /// This is a private constructor to support Singleton pattern
        /// </summary>
        private PortableDeviceObjectFactory()
        {
            this.factoryMethods = new Dictionary<Guid, FactoryMethodType>();

            // Register know object type
            this.RegisterNewFactoryMethod(PortableDeviceGuids.WPD_CONTENT_TYPE_FOLDER, CreateFolderObject);
            this.RegisterNewFactoryMethod(PortableDeviceGuids.WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT, CreateFunctionalObject);
        }

        #region Properties

        /// <summary>
        /// Gets the unique instance of factory
        /// </summary>
        public static PortableDeviceObjectFactory Instance
        {
            get { return instance ?? (instance = new PortableDeviceObjectFactory()); }
        }

        #endregion

        #region Public functions

        /// <summary>
        /// Register a new factory method that enable create new object type
        /// </summary>
        /// <param name="handledType"></param>
        /// <param name="method"></param>
        public void RegisterNewFactoryMethod(Guid handledType, FactoryMethodType method)
        {
            if (handledType == Guid.Empty)
                throw new ArgumentException("handledType cann't be Guid.Empty", "handledType");
            if (method == null)
                throw new ArgumentNullException("method");

            if (this.factoryMethods.ContainsKey(handledType))
                throw new ArgumentException(string.Format("Guid {0} is already registered", handledType), "handledType");

            this.factoryMethods.Add(handledType, method);
        }

        /// <summary>
        /// Create a new instance of a portableDeviceObject or derived from type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public PortableDeviceObject CreateInstance(Guid type, PortableDeviceApiLib.IPortableDeviceValues values)
        {
            if (this.factoryMethods.ContainsKey(type))
                return this.factoryMethods[type](values);
            else
                return this.CreateGenericObject(values);
        }

        #endregion

        #region Private functions

        private string GetObjectId(PortableDeviceApiLib.IPortableDeviceValues values)
        {
            string value;
            values.GetStringValue(ref PortableDevicePKeys.WPD_OBJECT_ID, out value);
            return value;
        }

        private PortableDeviceObject CreateFunctionalObject(PortableDeviceApiLib.IPortableDeviceValues values)
        {
            var obj = new PortableDeviceFunctionalObject(GetObjectId(values));
            this.InitializeInstance(obj, values);

            Guid category = new Guid();
            values.GetGuidValue(ref PortableDevicePKeys.WPD_FUNCTIONAL_OBJECT_CATEGORY, out category);
            obj.Category = category;

            return obj;
        }

        private PortableDeviceObject CreateFolderObject(PortableDeviceApiLib.IPortableDeviceValues values)
        {
            var obj = new PortableDeviceFolderObject(GetObjectId(values));
            this.InitializeInstance(obj, values);
            return obj;
        }

        private PortableDeviceObject CreateGenericObject(PortableDeviceApiLib.IPortableDeviceValues values)
        {
            var obj = new PortableDeviceObject(GetObjectId(values));
            this.InitializeInstance(obj, values);
            return obj;
        }

        private void InitializeInstance(PortableDeviceObject obj, PortableDeviceApiLib.IPortableDeviceValues values)
        {
            string name;
            values.GetStringValue(ref PortableDevicePKeys.WPD_OBJECT_NAME, out name);

            var guid = new Guid();
            values.GetGuidValue(ref PortableDevicePKeys.WPD_OBJECT_CONTENT_TYPE, out guid);
            string contentType = PortableDeviceHelpers.GetKeyNameFromGuid(guid);

            values.GetGuidValue(ref PortableDevicePKeys.WPD_OBJECT_FORMAT, out guid);
            string formatType = PortableDeviceHelpers.GetKeyNameFromGuid(guid);

            obj.Name = name;
            obj.ContentType = contentType;
            obj.Format = formatType;
        }

        #endregion

    }
}
