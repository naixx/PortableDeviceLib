using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableDeviceExplorer.ViewModels
{
    public class ViewModelLocator
    {

        private static MainWindowViewModel mainWindowViewModel;
        private static PortableDeviceViewerViewModel portableDeviceViewerViewModel;

        /// <summary>
        /// Gets the ViewModel for MainWindow view
        /// </summary>
        public static MainWindowViewModel MainWindowViewModel
        {
            get
            {
                if (mainWindowViewModel == null)
                    mainWindowViewModel = new MainWindowViewModel();
                return mainWindowViewModel;
            }
        }

        /// <summary>
        /// Gets the ViewModel for PortableDeviceViewer view
        /// </summary>
        public static PortableDeviceViewerViewModel PortableDeviceViewerViewModel
        {
            get
            {
                if (portableDeviceViewerViewModel == null)
                    portableDeviceViewerViewModel = new PortableDeviceViewerViewModel();

                return portableDeviceViewerViewModel;
            }
        }

    }
}
