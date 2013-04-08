using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableDeviceLib.Model
{
    /// <summary>
    /// Represent a fonctional object
    /// </summary>
    public class PortableDeviceFunctionalObject : PortableDeviceContainerObject
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="PortableDeviceFunctionalObject"/> class
        /// </summary>
        /// <param name="id"></param>
        public PortableDeviceFunctionalObject(string id)
            : base(id)
        {

        }
    }
}
