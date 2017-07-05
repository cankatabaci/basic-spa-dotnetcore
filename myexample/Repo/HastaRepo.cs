using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myexample.Model;


namespace myexample.Repo
{
    public class HastaRepo : IHastaRepo
    {
    List<Hasta> _hasta = new List<Hasta>
    {
        new Hasta { Id=1, Ad="Cankat", Soyad="Abacı",
                    Adres = new Adres{Id=1, Sehir="Ankara", Ilce="Elvankanet", PostaKod=060606}},
        new Hasta { Id=2, Ad="Wesley", Soyad="Sneijder",
                    Adres = new Adres{Id=2, Sehir="İstanbul", Ilce="Bakırköy", PostaKod=343434}},
        new Hasta { Id=3, Ad="Orkun", Soyad="Yiğit",
                    Adres = new Adres{Id=3, Sehir="İzmir", Ilce="Bornova", PostaKod=353535}}
    };

    public List<Hasta> Hastalar
    {
      get
      {
        return _hasta;
      }
    }

    }
}
