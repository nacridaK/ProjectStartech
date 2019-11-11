using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Formlar
{
    public partial class Form_Seriport : Form
    {
        public Form_Seriport()
        {
            InitializeComponent();
        }
        SeriPortKontrolcusu SeriportKontrolcusu;
        public Form_Seriport(SeriPortKontrolcusu seriportkontrolcu)
        {
            InitializeComponent();
            SeriportKontrolcusu = seriportkontrolcu;
            propertyGrid_Seriport.SelectedObject = SeriportKontrolcusu.SeriPort;
        }
        void Form_Seriport_FormClosing(object sender, FormClosingEventArgs e)
        {
            SeriportKontrolcusu.VeriSayisiDegistir((int)numericUpDown_Veri.Value);
            SeriportKontrolcusu.Form_SeriportKapatildi();
        }
    }
}