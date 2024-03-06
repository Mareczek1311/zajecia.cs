using System;

namespace Porownywarka
{
    class Program
    {
        static void Main(string[] args)
        {
            MaszynaSortujaca maszyna = new MaszynaSortujaca(new WagaPorownywarka());
            maszyna.DodajPojazd(new Samochod());
            maszyna.DodajPojazd(new Rower());
            maszyna.DodajPojazd(new Lodz());

            maszyna.pojazdy[0].waga = 3;
            maszyna.pojazdy[1].waga = 2;
            maszyna.pojazdy[2].waga = 5;

            maszyna.Sortuj();
            maszyna.Wypisz();
        }
    }
}
