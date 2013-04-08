using System;
using System.Collections.Generic;

namespace PortableDeviceLib.Model
{
    /// <summary>
    ///     Represent a description for an event
    /// </summary>
    public class PortableDeviceEventDescription
    {
        private readonly List<PortableDeviceEventOption> options;

        #region Constructors

        /// <summary>
        ///     Initialize a new instance of the <see cref="PortableDeviceEventDescription" /> class
        /// </summary>
        /// <param name="eventGuid">The event guid key</param>
        /// <param name="eventName">The event name</param>
        public PortableDeviceEventDescription(Guid eventGuid, string eventName)
        {
            if (eventGuid == Guid.Empty)
                throw new ArgumentException("eventGuid cann't be empty", "eventGuid");
            if (string.IsNullOrEmpty(eventName))
                throw new ArgumentNullException("eventName");

            options = new List<PortableDeviceEventOption>();
            Name = eventName;
            Guid = eventGuid;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the guid of the event
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        ///     Gets or sets the name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets the options of the event
        /// </summary>
        public IEnumerable<PortableDeviceEventOption> Options
        {
            get { return options; }
        }

        #endregion

        #region Public functions

        #endregion

        #region Internal functions

        /// <summary>
        ///     Add an option in the event description
        /// </summary>
        /// <param name="option"></param>
        internal void AddOptions(PortableDeviceEventOption option)
        {
            if (option == null)
                throw new ArgumentNullException("option");

            if (options.Contains(option))
                return;

            options.Add(option);
        }

        #endregion
    }
}