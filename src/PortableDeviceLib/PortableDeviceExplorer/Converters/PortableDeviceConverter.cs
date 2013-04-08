using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PortableDeviceLib;
using System.Windows.Data;

namespace PortableDeviceExplorer.Converters
{

    public class PortableDeviceConverter : IValueConverter
    {
        #region IValueConverter Membres

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(PortableDevice) || value == null || string.IsNullOrEmpty((string)value))
                return null;

            return PortableDeviceCollection.Instance.GetPortableDeviceById((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is PortableDevice)
                return ((PortableDevice)value).FriendlyName;

            return null;
        }

        #endregion
    }
}
