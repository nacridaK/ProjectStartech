using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.Donusturuculer
{
    public class BaudHiziDonusturucu : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int baudrate;
            int.TryParse(value.ToString(), out baudrate);
            if (baudrate <= 0)
                return null;
            return value;
        }
    }
}