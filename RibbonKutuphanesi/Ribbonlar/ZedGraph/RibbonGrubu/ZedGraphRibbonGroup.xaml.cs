using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.ZedGraph.RibbonGrubu
{
    /// <summary>
    /// ZedGraphRibbonGroup.xaml etkileşim mantığı
    /// </summary>
    public partial class ZedGraphRibbonGroup : RibbonGroup
    {
        public ZedGraphRibbonGroupViewModel ViewModel { get; set; }
        public ZedGraphRibbonGroup()
        {
            InitializeComponent();
        }
        public void GrafikKontrolcusuAyarla(GrafikKontrolcusu grafikontrolcusu)
        {
            ViewModel = new ZedGraphRibbonGroupViewModel { Kontrolcu = grafikontrolcusu };
            DataContext = ViewModel;
        }
    }
}