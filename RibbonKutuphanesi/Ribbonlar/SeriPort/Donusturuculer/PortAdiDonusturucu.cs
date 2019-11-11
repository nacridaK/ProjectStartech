using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.Donusturuculer
{
    public class PortAdiDonusturucu : IValueConverter
    {
        string PortAdi;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PortAdi = value.ToString();
            return PortAdi;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return PortAdi;
            return value;
        }
    }
}