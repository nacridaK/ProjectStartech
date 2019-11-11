using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZedGraphKutuphanesi.VeriIslemleri
{
    public class Olcek
    {
        [Category("Sınırlar")]
        [DefaultValue(-1)]
        [Description("Ölçeklenecek verinin alt sınırı")]
        [NotifyParentProperty(true)]
        public int AltSinir { get; set; }
        [Category("Sınırlar")]
        [DefaultValue(1)]
        [Description("Ölçeklenecek verinin alt sınırı")]
        [NotifyParentProperty(true)]
        public int UstSinir { get; set; }
        [Category("Olceklendirme Modu")]
        [DefaultValue(false)]
        [Description("Ölçeklenecek verinin alt sınırı")]
        [NotifyParentProperty(true)]
        public bool Olceklendirme { get; set; }
        public Olcek(int altSinir, int ustSinir, bool olceklendirme = false)
        {
            Olceklendirme = olceklendirme;
            AltSinir = altSinir;
            UstSinir = ustSinir;
        }
    }
}