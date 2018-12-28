using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public DateTime BasimYili { get; set; }

        public string YayinEvi { get; set; }

        public decimal Ucreti { get; set; }
        public bool AtandiMi { get; set; }
        public Turler turler { get; set; }
    }

    public enum Turler
    {
        Biyografi,
        Tarih,
        Genclik,
        Masal,
        Felsefe
        
    }
}
