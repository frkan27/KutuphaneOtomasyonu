using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
    public interface  IAtama<T1,T2> where T1:Kisi where T2:Kitap
    {
        void AtamaYap(T1 kime, T2 neyi);
    }
}
