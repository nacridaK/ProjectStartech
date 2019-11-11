using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraphKutuphanesi;
using RibbonKutuphanesi.Kontrolculer;

namespace Project_Startech
{
    public class ZedGraphGuncelleyici
    {
        BackgroundWorker Backgroundworker = new BackgroundWorker();
        ZedGraphKontrol[] GrafikKontrolleri;
        SeriPortKontrolcusu SeriportKontrolcusu;
        Panel panel_main;

        public ZedGraphGuncelleyici(SeriPortKontrolcusu seriportKontrolcusu, ZedGraphKontrol[] grafikKontrolleri, Panel panel)
        {
            panel_main = panel;

            Backgroundworker.DoWork += ZedGraphlariGuncelle;

            SeriportKontrolcusu = seriportKontrolcusu;
            SeriportKontrolcusu.SeriPortAcildi += GuncellemeyiBasla;
            seriportKontrolcusu.SeriPortKapandi += GuncellemeyiBitir;

            GrafikKontrolleri = grafikKontrolleri;
        }
        void GuncellemeyiBasla(object sender, EventArgs e)
        {
            Backgroundworker.RunWorkerCompleted += GuncellemeTamam;
            Backgroundworker.RunWorkerAsync();
        }
        void ZedGraphlariGuncelle(object sender, DoWorkEventArgs e)
        {
            int zedgraph_indis = panel_main.Controls[0].TabIndex;
            for (int i = (zedgraph_indis < 6) ? 0 : 6; i < SeriportKontrolcusu.VeriSayisi; i++)
            {
                if (!GrafikKontrolleri[i].GecmisiIncele)
                {
                    try
                    {
                        double sonDeger = GrafikKontrolleri[i].VeriListesi.SonXVerisi;
                        GrafikKontrolleri[i].X_EkseniniOlceklendir(sonDeger);
                    }
                    catch
                    {
                    }
                }
            }
            SeriportKontrolcusu.GercekZamanDegisiklikKontrol();
            Thread.Sleep(1);
        }
        void GuncellemeTamam(object sender, RunWorkerCompletedEventArgs e) => Backgroundworker.RunWorkerAsync();
        void GuncellemeyiBitir(object sender, EventArgs e) => Backgroundworker.RunWorkerCompleted -= GuncellemeTamam;
    }
}