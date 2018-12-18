using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
    public abstract class Kisi
    {
        private string Ad { get; set; }
        private string Soyad { get; set; }
        private DateTime DogumTarihi { get; set; }

        public override string ToString()
        {
            return $"{ this.Ad},{ this.Soyad}";
        }
    }
}
