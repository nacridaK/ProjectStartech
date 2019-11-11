using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZedGraph;
using ZedGraphKutuphanesi;

namespace RibbonKutuphanesi.Kontrolculer
{
    public class SeriPortKontrolcusu
    {
        #region Olaylar
        public event EventHandler SeriPortAcildi;
        public event EventHandler SeriPortKapandi;
        public event EventHandler Form_SeriportKapandi;
        public event EventHandler SeriPortListesiGuncellendi;
        public event EventHandler GercekZamanDegisti;
        #endregion

        public SerialPort SeriPort { get; }
        public Stopwatch StopWatch { get; } = new Stopwatch();
        public string[] SeriPortListe { get; set; } = SerialPort.GetPortNames();
        VeriKontrolcusu veriKontrolcusu { get; }

        public SeriPortKontrolcusu(SerialPort seriport, ZedGraphKontrol[] grafikKontrolleri)
        {
            SeriPort = seriport;          
            veriKontrolcusu = new VeriKontrolcusu(SeriPort, StopWatch, grafikKontrolleri);
        }
        public bool GercekZaman = true;
        public int VeriSayisi => veriKontrolcusu.VeriSayisi;
        public void VeriSayisiDegistir(int veriSayisi) => veriKontrolcusu.VeriSayisiDegistir(veriSayisi);

        public void GercekZamanDegisiklikKontrol()
        {
            if (SeriPort.IsOpen)
            {
                bool gercekZaman_son = SeriPort.BytesToRead <= SeriPort.ReceivedBytesThreshold;
                if (gercekZaman_son != GercekZaman)
                {
                    GercekZaman = gercekZaman_son;
                    GercekZamanDegisti?.Invoke(this, EventArgs.Empty);
                }
                    
            }
        }
        public void PortAc()
        {
            SeriPort.Open();
            SeriPort.DiscardInBuffer();
            StopWatch.Start();
            SeriPortAcildi?.Invoke(SeriPort, EventArgs.Empty);
        }
        public void PortKapat()
        {
            StopWatch.Stop();
            SeriPort.Close();
            SeriPortKapandi?.Invoke(SeriPort, EventArgs.Empty);
        }
        public void PortArabellekTemizle() => SeriPort.DiscardInBuffer();
        public void SeriportListesiGuncelle()
        {
            SeriPortListe = SerialPort.GetPortNames();
            SeriPortListesiGuncellendi?.Invoke(this, EventArgs.Empty);
        }
        public void Form_SeriportKapatildi() => Form_SeriportKapandi?.Invoke(this, EventArgs.Empty);
    }
}