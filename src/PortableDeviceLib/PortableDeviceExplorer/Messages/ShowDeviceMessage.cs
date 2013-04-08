using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortableDeviceLib;

namespace PortableDeviceExplorer.Messages
{
    /// <summary>
    /// Represent a message sended when current device change
    /// </summary>
    public class ShowDeviceMessage
    {
        /// <summary>
        /// Gets or sets the new current device
        /// </summary>
        public PortableDevice Device
        {
            get;
            set;
        }

    }
}
