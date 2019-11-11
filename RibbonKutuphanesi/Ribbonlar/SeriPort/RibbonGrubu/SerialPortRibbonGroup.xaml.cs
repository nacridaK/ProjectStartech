using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Ribbon;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.RibbonGrubu
{
    /// <summary>
    /// SerialPortRibbonGroup.xaml etkileşim mantığı
    /// </summary>
    public partial class SerialPortRibbonGroup : RibbonGroup
    {
        public SerialPortRibbonGroupViewModel ViewModel { get; set; }
        public SerialPortRibbonGroup()
        {
            InitializeComponent();
        }
        public void SeriportKontrolcusuAyarla(SeriPortKontrolcusu seriportKontrolcusu)
        {
            ViewModel = new SerialPortRibbonGroupViewModel { SeriportKontrolcusu = seriportKontrolcusu };
            DataContext = ViewModel;
        }
    }
}