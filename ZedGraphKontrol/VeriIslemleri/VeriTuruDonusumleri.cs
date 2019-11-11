using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZedGraphKutuphanesi.VeriIslemleri
{
    public static class VeriTuruDonusumleri
    {
        public static double DogrusalOlceklendir(double veri, VeriTuru veriTuru, int altSinir, int ustSinir)
        {
            int bitSayisi = 8 * VeriBoyutuDondur(veriTuru);
            return veri / (Math.Pow(2, bitSayisi) - 1) * (ustSinir - altSinir) + altSinir;
        }
        public delegate double DonusturMethodu(byte[] deger, int baslangicIndisi);
        public static DonusturMethodu[] Methodlar { get; } =
        {
            ToByte,
            ToChar,
            ToDouble,
            ToInt16,
            ToInt32,
            ToInt64,
            ToSingle,
            ToUInt16,
            ToUInt32,
            ToUInt64
        };
        static int[] VeriBoyutlari { get; } = { 1, 2, 8, 2, 4, 8, 4, 2, 4, 8 };
        public static int VeriBoyutuDondur(VeriTuru tur) => VeriBoyutlari[(int)tur];
        static double ToByte(byte[] value, int startIndex) => value[startIndex];
        static double ToChar(byte[] value, int startIndex) => BitConverter.ToChar(value, startIndex);
        static double ToDouble(byte[] value, int startIndex) => BitConverter.ToDouble(value, startIndex);
        static double ToInt16(byte[] value, int startIndex) => BitConverter.ToInt16(value, startIndex);
        static double ToInt32(byte[] value, int startIndex) => BitConverter.ToInt32(value, startIndex);
        static double ToInt64(byte[] value, int startIndex) => BitConverter.ToInt64(value, startIndex);
        static double ToSingle(byte[] value, int startIndex) => BitConverter.ToSingle(value, startIndex);
        static double ToUInt16(byte[] value, int startIndex) => BitConverter.ToUInt16(value, startIndex);
        static double ToUInt32(byte[] value, int startIndex) => BitConverter.ToUInt32(value, startIndex);
        static double ToUInt64(byte[] value, int startIndex) => BitConverter.ToUInt64(value, startIndex);
    }
}