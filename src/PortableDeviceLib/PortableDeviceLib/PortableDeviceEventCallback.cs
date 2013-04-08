using System;
using PortableDeviceApiLib;
using PortableDeviceLib.Factories;

namespace PortableDeviceLib
{
    /// <summary>
    ///     Manage event from device
    /// </summary>
    internal class PortableDeviceEventCallback : IPortableDeviceEventCallback
    {
        private readonly PortableDevice device;

        /// <summary>
        ///     Initialize an new instance of the <see cref="PortableDeviceEventCallback" /> class
        /// </summary>
        /// <param name="portableDevice"></param>
        internal PortableDeviceEventCallback(PortableDevice portableDevice)
        {
            if (portableDevice == null)
                throw new ArgumentNullException("portableDevice");

            device = portableDevice;
        }

        /// <summary>
        ///     Callback for event from device
        /// </summary>
        /// <param name="pEventParameters"></param>
        public void OnEvent(IPortableDeviceValues pEventParameters)
        {
            string pnpDeviceId;
            pEventParameters.GetStringValue(ref PortableDevicePKeys.WPD_EVENT_PARAMETER_PNP_DEVICE_ID, out pnpDeviceId);
            if (device.DeviceId != pnpDeviceId)
                return;

            Guid eventGuid;
            pEventParameters.GetGuidValue(ref PortableDevicePKeys.WPD_EVENT_PARAMETER_EVENT_ID, out eventGuid);

            device.RaiseEvent(PortableDeviceEventTypeFactory.Instance.CreateEventType(eventGuid));
        }
    }
}