using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RibbonKutuphanesi.Ribbonlar.SeriPort.Komutlar;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.RibbonGrubu
{
    public class SerialPortRibbonGroupViewModel: INotifyPropertyChanged
    {
        public ArabellekTemizleKomutu ArabellekTemizleKomut { get; set; }
        public PortDurumDegistirKomutu PortDurumDegistirKomut { get; set; }
        public Form_SeriportAcKomutu Form_SeriportAcKomut { get; set; }
        public SeriportListesiYenileKomutu SeriportListesiYenileKomut { get; set; }
        public ZamanıSifirlaKomutu ZamanıSifirlaKomut { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        SeriPortKontrolcusu _seriportKontrolcusu;

        public SeriPortKontrolcusu SeriportKontrolcusu
        {
            get => _seriportKontrolcusu;
            set
            {
                _seriportKontrolcusu = value;
                _seriportKontrolcusu.SeriPortAcildi += ViewGuncelle;
                _seriportKontrolcusu.SeriPortKapandi += ViewGuncelle;
                _seriportKontrolcusu.SeriPortListesiGuncellendi += ViewGuncelle;
                _seriportKontrolcusu.Form_SeriportKapandi += ViewGuncelle;
                _seriportKontrolcusu.GercekZamanDegisti += GercekZamanDegisti;
                ArabellekTemizleKomut = new ArabellekTemizleKomutu(_seriportKontrolcusu);
                PortDurumDegistirKomut = new PortDurumDegistirKomutu(_seriportKontrolcusu);
                Form_SeriportAcKomut = new Form_SeriportAcKomutu(_seriportKontrolcusu);
                SeriportListesiYenileKomut = new SeriportListesiYenileKomutu(_seriportKontrolcusu);
                ZamanıSifirlaKomut = new ZamanıSifirlaKomutu(_seriportKontrolcusu);
            }
        }
        public bool GercekZaman =>_seriportKontrolcusu.GercekZaman;
        public string PortAdi
        {
            get => _seriportKontrolcusu.SeriPort.PortName;
            set
            {
                _seriportKontrolcusu.SeriPort.PortName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PortAdi"));
            }
        }
        public int BaudHizi
        {
            get => _seriportKontrolcusu.SeriPort.BaudRate;
            set
            {
                _seriportKontrolcusu.SeriPort.BaudRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BaudHizi"));
            }
        }
        public string[] SeriPortListe => SerialPort.GetPortNames();
        public bool PortDurumu => _seriportKontrolcusu.SeriPort.IsOpen;
        void ViewGuncelle(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PortAdi"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BaudHizi"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PortDurumu"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SeriPortListe"));
        }
        void GercekZamanDegisti(object sender, EventArgs e) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GercekZaman"));
    }
}