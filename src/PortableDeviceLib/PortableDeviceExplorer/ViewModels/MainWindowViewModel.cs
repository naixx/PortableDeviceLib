using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using PortableDeviceLib;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using PortableDeviceExplorer.Messages;

namespace PortableDeviceExplorer.ViewModels
{
    /// <summary>
    /// Manage the MainWindows view
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        private const string AppName = "PortableDeviceExplorer";
        private const int AppMajorVersionNumber = 1;
        private const int AppMinorVersionNumber = 0;
        private PortableDevice selectedPortableDevice;

        #region Constructors

        /// <summary>
        /// Initialize a new instance of the <see cref="MainWindowViewModel"/> class
        /// </summary>
        public MainWindowViewModel()
            : base()
        {
            this.PortableDevices = new ObservableCollection<PortableDevice>();

            this.ConnectToDeviceCommand = new RelayCommand<PortableDevice>(new Action<PortableDevice>(this.ConnectToDevice), new Predicate<PortableDevice>(this.CanConnectToDevice));
            this.DisconnectFromDeviceCommand = new RelayCommand(new Action(this.DisconnectFromDevice), new Func<bool>(this.CanDisconnectFromDevice));
            this.RefreshConnectedDeviceCommand = new RelayCommand(new Action(this.RefreshConnectedDevices));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the current selected device
        /// </summary>
        public PortableDevice SelectedPortableDevice
        {
            get { return this.selectedPortableDevice; }
            set
            {
                if (this.selectedPortableDevice != value)
                {
                    this.selectedPortableDevice = value;
                    this.RaisePropertyChanged("SelectedPortableDevice");
                    Messenger.Default.Send(new ShowDeviceMessage() { Device = value });
                }
            }
        }

        /// <summary>
        /// Gets the <see cref="PortableDevice"/> connected
        /// </summary>
        public ObservableCollection<PortableDevice> PortableDevices
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the command for connecting to a device
        /// </summary>
        public RelayCommand<PortableDevice> ConnectToDeviceCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the command for disconnecting from device
        /// </summary>
        public RelayCommand DisconnectFromDeviceCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the command for refreshing connected device
        /// </summary>
        public RelayCommand RefreshConnectedDeviceCommand
        {
            get;
            private set;
        }

        #endregion

        #region Public functions

        #endregion

        #region Private functions

        private void ConnectToDevice(PortableDevice portableDevice)
        {
            portableDevice.ConnectToDevice(AppName, AppMajorVersionNumber, AppMinorVersionNumber);
            this.SelectedPortableDevice = portableDevice;
        }

        private bool CanConnectToDevice(PortableDevice portableDevice)
        {
            return portableDevice != null && !portableDevice.IsConnected;
        }

        private void DisconnectFromDevice()
        {
            this.SelectedPortableDevice.Disconnect();
        }

        private bool CanDisconnectFromDevice()
        {
            return this.selectedPortableDevice != null && this.selectedPortableDevice.IsConnected;
        }

        private void RefreshConnectedDevices()
        {
            this.PortableDevices.Clear();

            if (PortableDeviceCollection.Instance == null)
            {
                PortableDeviceCollection.CreateInstance(AppName, AppMajorVersionNumber, AppMinorVersionNumber);
                PortableDeviceCollection.Instance.AutoConnectToPortableDevice = false;
            }

            foreach (var device in PortableDeviceCollection.Instance.Devices)
            {
                this.PortableDevices.Add(device);
            }
        }

        #endregion
    }
}
