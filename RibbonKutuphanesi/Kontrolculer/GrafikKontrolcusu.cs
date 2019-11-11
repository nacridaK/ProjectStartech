using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using ZedGraphKutuphanesi;

namespace RibbonKutuphanesi.Kontrolculer
{
    public class GrafikKontrolcusu
    {
        public EventHandler BaslikDegisti;
        public EventHandler Form_ZedGraphKapandi;
        public ZedGraphKontrol GrafikKontrol { get; }

        public GrafikKontrolcusu(ZedGraphKontrol grafikKontrol) => GrafikKontrol = grafikKontrol;
        public void BaslikDegistir(string baslik)
        {
            GrafikKontrol.GraphPane.Title.Text = baslik;
            BaslikDegisti?.Invoke(this, EventArgs.Empty);
        }
        public void Temizle() => GrafikKontrol.VerileriTemizle();
        public void JPGKaydet()
        {
            Bitmap bitmap = GrafikKontrol.GraphPane.GetImage();
            bitmap.Save("Fotoğraf - " + DateTime.Now.ToString("yyyy/MM/dd HH.mm.ss") + ".jpeg", ImageFormat.Jpeg);
        }
        public void TXTKaydet()
        {
            TextWriter txtyazici = new StreamWriter("Kayıt - " + DateTime.Now.ToString("yyyy/MM/dd HH.mm.ss") + ".txt");
            txtyazici.WriteLine("Project Startech Çıktı Ekranı\r\n\r\n");
            txtyazici.WriteLine("Çıktısı alınan grafik\t: Grafik " + GrafikKontrol.TabIndex + " \r\n\r\n");
            txtyazici.WriteLine("Çıktı zamanı\t\t: " + DateTime.Now.ToString() + "\r\n");
            txtyazici.WriteLine("Toplam nokta sayısı\t: " + GrafikKontrol.VeriListesi.Count + "\r\n\r\n");
            txtyazici.WriteLine("Zaman\t\tDeğer\r\n");
            for (int i = 0; i < GrafikKontrol.VeriListesi.Count; i++)
                txtyazici.WriteLine(((XDate)GrafikKontrol.VeriListesi[i].X).ToString("mm:ss.fff") + "\t" + GrafikKontrol.VeriListesi[i].Y);
            txtyazici.Close();
        }
        public void Form_ZedGraphKapatildi() => Form_ZedGraphKapandi?.Invoke(this, EventArgs.Empty);
    }
}
