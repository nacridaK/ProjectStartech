using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraphKutuphanesi;
using RibbonKutuphanesi.Kontrolculer;

namespace Project_Startech
{
    public partial class FormMain : Form
    {
        SeriPortKontrolcusu seriportKontrolcusu;
        GrafikKontrolcusu[] grafikKontrolculeri;
        ZedGraphGuncelleyici guncelleyici;
        ZedGraphKontrol[] grafikler;
        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            grafikler = new ZedGraphKontrol[] { zedGraphKontrol01, zedGraphKontrol02, zedGraphKontrol03, zedGraphKontrol04, zedGraphKontrol05, zedGraphKontrol06, zedGraphKontrol07, zedGraphKontrol08, zedGraphKontrol09, zedGraphKontrol10, zedGraphKontrol11, zedGraphKontrol12 };
            grafikKontrolculeri = new GrafikKontrolcusu[grafikler.Length];
            for (int i = 0; i < grafikKontrolculeri.Length; i++)
                grafikKontrolculeri[i] = new GrafikKontrolcusu(grafikler[i]);
            seriportKontrolcusu = new SeriPortKontrolcusu(SeriPort, grafikler);
            Ribbon.BaslangicAyarlari(panel_main, seriportKontrolcusu, grafikKontrolculeri);
            guncelleyici = new ZedGraphGuncelleyici(seriportKontrolcusu, grafikler, panel_main);
        }
        void SeriPortKontrolu(object sender, FormClosingEventArgs e) => e.Cancel = SeriPort.IsOpen;
    }
}