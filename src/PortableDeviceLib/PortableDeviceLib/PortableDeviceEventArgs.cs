using System;
using PortableDeviceLib.Model;

namespace PortableDeviceLib
{
    public class PortableDeviceEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        ///     Initialize a new instance of the <see cref="PortableDeviceEventArgs" /> class
        /// </summary>
        public PortableDeviceEventArgs()
        {
        }

        /// <summary>
        ///     Initialize a new instance of the <see cref="PortableDeviceEventArgs" /> class
        /// </summary>
        /// <param name="eventType">The event type</param>
        public PortableDeviceEventArgs(PortableDeviceEventType eventType)
            : this()
        {
            EventType = eventType;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the event guid.
        /// </summary>
        public PortableDeviceEventType EventType { get; set; }

        #endregion
    }
}