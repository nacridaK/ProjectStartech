using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using ZedGraphKutuphanesi.VeriIslemleri;
using static ZedGraphKutuphanesi.VeriIslemleri.VeriTuruDonusumleri;

namespace RibbonKutuphanesi.Ribbonlar.ZedGraph.Donusturuculer
{
    public class VeriTuruDonusturucu : IValueConverter
    {
        VeriTuru Tur;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Tur = (VeriTuru)value;
            return value.ToString() + " (" + VeriBoyutuDondur(Tur) + ')';
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.GetType() == typeof(string))
                return Tur;
            return (VeriTuru)((RibbonGalleryCategory)((RibbonGalleryItem)value).Parent).Items.IndexOf(value);
        }
    }
}