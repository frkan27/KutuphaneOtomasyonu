using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Data
{
    public class SimData
    {
        public States States { get; set; }

        public SimData()
            {
            States = new States();

            for (int i = 0; i < 10; i++)
            {
                States.Ogrenciler.Add(new Ogrenci()
                    {

                    
                });

            }
}
    }
}
