using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Data
{
   public  class States
    {
        public List<Yazar> Yazarlar { get; set; } = new List<Yazar>();
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();
        public List<KitapAlim> KitapAlimlar { get; set; } = new List<KitapAlim>();
    }
}
