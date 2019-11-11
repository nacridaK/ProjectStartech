using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using ZedGraphKutuphanesi;

namespace RibbonKutuphanesi.Kontrolculer
{
    public class VeriKontrolcusu
    {
        PointPairListBase[] VeriListeleri { get; }
        SerialPort Seriport { get; }
        Stopwatch StopWatch { get; }
        public int VeriSayisi { get; private set; } = 12;

        byte[] Arabellek;
        public VeriKontrolcusu(SerialPort seriport, Stopwatch stopwatch, ZedGraphKontrol[] grafikKontrolleri)
        {
            Seriport = seriport;
            StopWatch = stopwatch;
            Seriport.DataReceived += VeriPaketiGeldi;
            int len = 0;
            for (int i = 0; i < grafikKontrolleri.Length; i++)
                len += grafikKontrolleri[i].VeriListesiSayisi;
            VeriListeleri = new PointPairListBase[len];
            for (int i = 0; i < len; i++)
            {
                VeriListeleri[i] = grafikKontrolleri[i].VeriListesi;
                VeriListeleri[i].VeriTuruDegisti += Seriport_ThresholdHesapla;
            }
            Seriport_ThresholdHesapla(null, EventArgs.Empty);
        }
        void VeriPaketiGeldi(object sender, SerialDataReceivedEventArgs e)
        {
            TimeSpan timespan_zaman = StopWatch.Elapsed;
            for (int i = 0; i < Seriport.ReceivedBytesThreshold; i++)
                Arabellek[i] = (byte)Seriport.ReadByte();
            XDate xdate_zaman = new XDate(1899, 12, 30, timespan_zaman.Hours, timespan_zaman.Minutes, timespan_zaman.Seconds, timespan_zaman.Milliseconds);
            int baslangicIndisi = 0;
            for (int i = 0; i < VeriSayisi; i++)
                baslangicIndisi += VeriListeleri[i].DonusturVeEkle(xdate_zaman, Arabellek, baslangicIndisi);
            //noktalar[i / 2].Add(zaman1, (360 * BitConverter.ToUInt16(veriler, i) / 1023 - 180));
            //0
            //65519
            //65535
        }
        public void VeriSayisiDegistir(int veriSayisi)
        {
            VeriSayisi = veriSayisi;
            Seriport_ThresholdHesapla(null, EventArgs.Empty);
        }
        void Seriport_ThresholdHesapla(object sender, EventArgs e)
        {
            Seriport.ReceivedBytesThreshold = 1;
            for (int i = 0; i < VeriSayisi; i++)
                Seriport.ReceivedBytesThreshold += VeriListeleri[i].VeriBoyutu;
            Arabellek = new byte[--Seriport.ReceivedBytesThreshold];
        }
    }
}