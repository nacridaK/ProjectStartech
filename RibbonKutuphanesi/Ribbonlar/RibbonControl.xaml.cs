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
using System.Windows.Forms;
using RibbonKutuphanesi.Ribbonlar.ZedGraph.RibbonGrubu;
using RibbonKutuphanesi.Kontrolculer;
using RibbonKutuphanesi.Formlar;

namespace RibbonLib.Ribbonlar
{
    /// <summary>
    /// RibbonControl.xaml etkileşim mantığı
    /// </summary>
    public partial class RibbonControl : System.Windows.Controls.UserControl
    {
        ZedGraphRibbonGroup[] grafikRibbonGruplari;
        System.Windows.Forms.Panel panel_main;
        public RibbonControl()
        {
            InitializeComponent();
            grafikRibbonGruplari = new ZedGraphRibbonGroup[] { RibbonGroup_Grafik01, RibbonGroup_Grafik02, RibbonGroup_Grafik03, RibbonGroup_Grafik04, RibbonGroup_Grafik05, RibbonGroup_Grafik06, RibbonGroup_Grafik07, RibbonGroup_Grafik08, RibbonGroup_Grafik09, RibbonGroup_Grafik10, RibbonGroup_Grafik11, RibbonGroup_Grafik12 };
            DataContext = this;
        }
        public void BaslangicAyarlari(System.Windows.Forms.Panel panel, SeriPortKontrolcusu seriportKontrolcusu, GrafikKontrolcusu[] grafikKontrolculeri)
        {
            PanelAyarla(panel);
            SeriportKontrolcusuAyarla(seriportKontrolcusu);
            GrafikKontrolculeriAyarla(grafikKontrolculeri);
        }
        void PanelAyarla(System.Windows.Forms.Panel panel) => panel_main = panel;
        void SeriportKontrolcusuAyarla(SeriPortKontrolcusu seriportKontrolcusu)
        {
            RibbonGroup_Seriport1.SeriportKontrolcusuAyarla(seriportKontrolcusu);
            RibbonGroup_SeriPort2.SeriportKontrolcusuAyarla(seriportKontrolcusu);
        }
        void GrafikKontrolculeriAyarla(GrafikKontrolcusu[] grafikKontrolculeri)
        {
            for (int i = 0; i < grafikRibbonGruplari.Length; i++)
                grafikRibbonGruplari[i].GrafikKontrolcusuAyarla(grafikKontrolculeri[i]);
        }
        void PanelSirasiniDegistir(object sender, SelectionChangedEventArgs e) => panel_main.Controls[1].BringToFront();
        void RibbonApplicationMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Form_Hakkinda form_Hakkinda = new Form_Hakkinda();
            form_Hakkinda.ShowDialog();
        }
    }
}