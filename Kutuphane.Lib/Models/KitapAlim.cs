using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
   public class KitapAlim
    {
        public Ogrenci Ogrenci { get; set; }

        public Yazar Yazar { get; set; }

        public int Sure { get; set; }
    }
}
