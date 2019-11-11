using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using ZedGraphKutuphanesi.VeriIslemleri;
using static ZedGraphKutuphanesi.VeriIslemleri.VeriTuruDonusumleri;

namespace ZedGraphKutuphanesi
{
    public class PointPairListBase : PointPairList
    {
        static double BaslangicZamani { get; } = new XDate(1899, 12, 30, 0, 0, 0, 0).XLDate;

        public event EventHandler VeriTuruDegisti;

        Olcek _olcek = new Olcek(-1, 1);
        public Olcek OlcekBilgisi => _olcek;
        public VeriTuru Tur { get; private set; }
        public int VeriBoyutu => VeriBoyutuDondur(Tur);
        DonusturMethodu Donustur => Methodlar[(int)Tur];
        public double SonXVerisi
        {
            get
            {
                if (Count == 0)
                    return BaslangicZamani;
                return this[Count - 1].X;
            }
        }
        public PointPairListBase(VeriTuru tur = VeriTuru.Byte) => Tur = tur;
        public int DonusturVeEkle(double x, byte[] deger, int baslangicIndisi)
        {
            double veri = Donustur(deger, baslangicIndisi);
            if (OlcekBilgisi.Olceklendirme)
                veri = DogrusalOlceklendir(veri, Tur, OlcekBilgisi.AltSinir, OlcekBilgisi.UstSinir);
            Add(x, veri);
            return VeriBoyutu;
        }
        public void VeriTuruDegistir(VeriTuru tur)
        {
            Tur = tur;
            VeriTuruDegisti?.Invoke(this, EventArgs.Empty);
        }
    }
}