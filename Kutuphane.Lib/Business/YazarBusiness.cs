using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Business
{
    public class YazarBusiness : IAtama<Yazar, Kitap>
    {
        public void AtamaYap(Yazar kime, Kitap neyi)
        {
            if(neyi.AtandiMi)
            throw new Exception("Bu kitap daha önce atanmıştır.");
            if (kime.turler != neyi.turler)
                throw new Exception(" yazar kitap birlikte olmalı.");
                    neyi.AtandiMi = true;
            kime.kitaplar.Add(neyi);

        }
    }
}
