﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
    public class Yazar:Kisi
    {
        
        public Turler turler { get; set; }

        public List<Kitap> kitaplar { get; set; } = new List<Kitap>();
    }
}
