using System;
using System.Collections.Generic;
using PortableDeviceLib.Model;

namespace PortableDeviceLib.Factories
{
    /// <summary>
    ///     Represent a factory that can construct new <see cref="PortableDeviceEventType" /> object
    /// </summary>
    public class PortableDeviceEventTypeFactory
    {
        private static PortableDeviceEventTypeFactory instance;

        private readonly Dictionary<Guid, Func<PortableDeviceEventType>> factoryMethods;

        private PortableDeviceEventTypeFactory()
        {
            factoryMethods = new Dictionary<Guid, Func<PortableDeviceEventType>>();
        }

        #region Properties

        /// <summary>
        ///     Gets the unique instance of the <see cref="PortableDeviceEventTypeFactory" />
        /// </summary>
        public static PortableDeviceEventTypeFactory Instance
        {
            get { return instance ?? (instance = new PortableDeviceEventTypeFactory()); }
        }

        #endregion

        #region Public functions

        /// <summary>
        ///     Create a new instance of the
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public PortableDeviceEventType CreateEventType(Guid guid)
        {
            if (factoryMethods.ContainsKey(guid))
                return factoryMethods[guid]();
            else
                return new PortableDeviceEventType();
        }

        #endregion
    }
}