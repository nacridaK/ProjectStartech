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
    public partial class Form_Grafik : Form
    {
        public Form_Grafik()
        {
            InitializeComponent();
        }
        GrafikKontrolcusu Kontrolcu;
        public Form_Grafik(GrafikKontrolcusu kontrolcu)
        {
            InitializeComponent();
            Kontrolcu = kontrolcu;
            textBox_Grafik.Text = Kontrolcu.GrafikKontrol.GraphPane.Title.Text;
            propertyGrid_Olcek.SelectedObject = Kontrolcu.GrafikKontrol.VeriListesi.OlcekBilgisi;
        }
        private void Form_Grafik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kontrolcu.BaslikDegistir(textBox_Grafik.Text);
            Kontrolcu.Form_ZedGraphKapatildi();
        }
    }
}