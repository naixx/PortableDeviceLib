using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableDeviceLib.Model
{
    /// <summary>
    /// Represents physical file
    /// </summary>
    class PortableDeviceFileObject : PortableDeviceObject
    {
        public PortableDeviceFileObject(string id) : base(id)
        {
        }

        /// <summary>
        /// Actual filename
        /// </summary>
        public string FileName { get; internal set; }
    }
}
