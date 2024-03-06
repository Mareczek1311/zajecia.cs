using System;

namespace Porownywarka
{
    class MaszynaSortujaca
    {
        IPorownywarka porownywarka;
        public Pojazd[] pojazdy;
        int iloscPojazdow;

        public MaszynaSortujaca(IPorownywarka p)
        {
            porownywarka = p;
            pojazdy = new Pojazd[10];
            iloscPojazdow = 0;
        }

        public void DodajPojazd(Pojazd pojazd)
        {
            if (iloscPojazdow < pojazdy.Length){
                pojazdy[iloscPojazdow] = pojazd;
                iloscPojazdow++;
            }
            else
            {
                Console.WriteLine("NIE MA MIEJSCA!");
            }
        }

        public void Sortuj()
        {
            Array.Sort(pojazdy, 0, iloscPojazdow, new PorownywarkaComparer(porownywarka));
        }

        public void Wypisz()
        {

            for(int i=0; i<iloscPojazdow; i++)
            {
                Console.WriteLine(pojazdy[i].GetType().Name);
            }

        }
    }


}
