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
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime()


                });

            }
            for (int i = 0; i < 10; i++)
            {
                States.Yazarlar.Add(new Yazar()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    turler = FakeData.EnumData.GetElement<Turler>()
                });
            }
            for (int i = 0; i < 20; i++)
            {
                States.Kitaplar.Add(new Kitap()
                {
                    KitapAdi = FakeData.NameData.GetFirstName(),
                    YayinEvi = FakeData.NameData.GetSurname(),
                    BasimYili = FakeData.DateTimeData.GetDatetime(),
                    turler = FakeData.EnumData.GetElement<Turler>()
                });
            }
        }
    }
}
