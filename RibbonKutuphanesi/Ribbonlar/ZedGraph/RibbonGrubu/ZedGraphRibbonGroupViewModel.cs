using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RibbonKutuphanesi.Ribbonlar.ZedGraph.Komutlar;
using RibbonKutuphanesi.Kontrolculer;
using ZedGraphKutuphanesi.VeriIslemleri;

namespace RibbonKutuphanesi.Ribbonlar.ZedGraph.RibbonGrubu
{
    public class ZedGraphRibbonGroupViewModel : INotifyPropertyChanged
    {
        public Form_GrafikAcKomutu GrafikAcKomut { get; set; }
        public GrafigiTemizleKomutu GrafigiTemizleKomut { get; set; }
        public GrafigiKaydetKomutu GrafigiKaydetKomut { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        GrafikKontrolcusu _grafikKontrolcusu;

        public GrafikKontrolcusu Kontrolcu
        {
            get => _grafikKontrolcusu;
            set
            {
                _grafikKontrolcusu = value;
                _grafikKontrolcusu.BaslikDegisti += ViewGuncelle;
                GrafikAcKomut = new Form_GrafikAcKomutu(_grafikKontrolcusu);
                GrafigiTemizleKomut = new GrafigiTemizleKomutu(_grafikKontrolcusu);
                GrafigiKaydetKomut = new GrafigiKaydetKomutu(_grafikKontrolcusu);
            }
        }
        public string Baslik => Kontrolcu.GrafikKontrol.GraphPane.Title.Text;
        public Olcek OlcekBilgisi => Kontrolcu.GrafikKontrol.VeriListesi.OlcekBilgisi;

        public VeriTuru Tur
        {
            get => Kontrolcu.GrafikKontrol.Tur;
            set => Kontrolcu.GrafikKontrol.Tur = value;
        }
        public bool GecmisiIncele
        {
            get => Kontrolcu.GrafikKontrol.GecmisiIncele;
            set
            {
                Kontrolcu.GrafikKontrol.GecmisiIncele = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GecmisiIncele"));
            }
        }
        public void BaslikDegistir(string baslik)
        {
            Kontrolcu.GrafikKontrol.GraphPane.Title.Text = baslik;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Baslik"));
        }
        void ViewGuncelle(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tur"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GecmisiIncele"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Baslik"));
        }
    }
}