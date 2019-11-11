using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Drawing;
using ZedGraphKutuphanesi.VeriIslemleri;

namespace ZedGraphKutuphanesi
{
    public class ZedGraphKontrol : ZedGraphControl
    {
        static int Adet;

        int GrafikNumarasi = ++Adet;
        int OlcekKatsayisi = 1200;
        bool HizliOlcekleme;
        public PointPairListBase VeriListesi { get; } = new PointPairListBase();
        LineItem Grafik;

        bool _GecmisiIncele;
        public bool GecmisiIncele
        {
            get => _GecmisiIncele;
            set
            {
                SetScrollRangeFromData();
                IsEnableHZoom = value;
                IsEnableHPan = value;
                IsShowHScrollBar = value;
                _GecmisiIncele = value;
            }
        }
        public VeriTuru Tur
        {
            get => VeriListesi.Tur;
            set
            {
                VeriListesi.VeriTuruDegistir(value);
            }
        }
        public int VeriListesiSayisi => GraphPane.CurveList.Count;
        public ZedGraphKontrol()
        {
            GraphPane.Title.Text = "Seri Port Grafiği " + GrafikNumarasi;
            //GraphPane.TitleGap = -1.2f;
            GraphPane.XAxis.Title.Text = "Zaman";
            //GraphPane.XAxis.Title.Gap = -0.2f;
            GraphPane.XAxis.Type = AxisType.Date;
            GraphPane.XAxis.Scale.Format = "mm:ss.fff";
            GraphPane.XAxis.MinorGrid.IsVisible = true;
            GraphPane.XAxis.MajorGrid.IsVisible = true;
            GraphPane.XAxis.Scale.MajorStepAuto = true;
            GraphPane.XAxis.Scale.MinorStepAuto = true;
            GraphPane.YAxis.IsVisible = false;
            GraphPane.Y2Axis.IsVisible = true;
            GraphPane.Y2Axis.Title.Text = "Değer";
            //GraphPane.Y2Axis.Title.Gap = -0.3f;
            GraphPane.Y2Axis.Scale.MaxAuto = true;
            GraphPane.Y2Axis.Scale.MinAuto = true;
            GraphPane.Y2Axis.MinorGrid.IsVisible = true;
            GraphPane.Y2Axis.MajorGrid.IsVisible = true;
            GraphPane.Y2Axis.Scale.MajorStepAuto = true;

            IsShowContextMenu = false;
            GraphPane.Legend.IsVisible = false;
            IsEnableVZoom = false;
            IsEnableHZoom = false;
            IsEnableHPan = false;
            IsShowHScrollBar = false;
            Grafik = GraphPane.AddCurve("Veri " + GrafikNumarasi, VeriListesi, Color.Black, SymbolType.VDash);
        }
        public void X_EkseniniOlceklendir(double yeniDeger)
        {
            GraphPane.XAxis.Scale.Max = yeniDeger + 0.0000002;
            double xMin = yeniDeger - 0.00000001 * OlcekKatsayisi;
            if (xMin < 0)
                xMin = 0;
            GraphPane.XAxis.Scale.Min = xMin;
            GraphPane.AxisChange();
            Refresh();
        }
        public void VerileriTemizle()
        {
            VeriListesi.Clear();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && !GecmisiIncele)
                HizliOlcekleme = !HizliOlcekleme;
            base.OnMouseClick(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int olcekKatsayisi = OlcekKatsayisi;
            if (!GecmisiIncele)
            {
                if (HizliOlcekleme)
                    olcekKatsayisi += e.Delta;
                else
                    olcekKatsayisi += e.Delta / 10;
                if (olcekKatsayisi > 0)
                    OlcekKatsayisi = olcekKatsayisi;
            }
            base.OnMouseWheel(e);
        }
    }
}