using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using PortableDeviceLib;
using GalaSoft.MvvmLight.Messaging;
using PortableDeviceExplorer.Messages;

namespace PortableDeviceExplorer.ViewModels
{
    /// <summary>
    /// Manage <see cref="PortableDeviceViewer"/> view
    /// </summary>
    public class PortableDeviceViewerViewModel : ViewModelBase
    {
        private PortableDevice portableDevice;

        /// <summary>
        /// Initialize a new instance of the <see cref="PortableDeviceViewerViewModel"/> class
        /// </summary>
        public PortableDeviceViewerViewModel()
            : base()
        {
            Messenger.Default.Register(this, new Action<ShowDeviceMessage>(this.ChangeCurrentDevice));
        }

        /// <summary>
        /// Gets or sets the current PortableDevice
        /// </summary>
        public PortableDevice PortableDevice
        {
            get { return this.portableDevice; }
            set
            {
                if (this.portableDevice != value)
                {
                    this.portableDevice = value;
                    this.RaisePropertyChanged("PortableDevice");
                }
            }
        }


        private void ChangeCurrentDevice(ShowDeviceMessage msg)
        {
            this.PortableDevice = msg.Device;
            this.PortableDevice.RefreshContent();
        }
    }
}
