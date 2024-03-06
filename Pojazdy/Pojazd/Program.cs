using System;

namespace Pojazd
{
    abstract class Pojazd
    {
        private int miejsca;
        private int kola;
        private int cena;
        private int waga;

        public void UstawIloscMiejsc(int ilosc)
        {
            miejsca = ilosc;
        }

        public void UstawIloscKol(int ilosc)
        {
            kola = ilosc;
        }

        public void UstawIloscCena(int ilosc)
        {
            cena = ilosc;
        }

        public void UstawIloscWaga(int ilosc)
        {
            waga = ilosc;
        }


        public abstract bool CzyToWieloslad();
        public abstract bool CzyMaDach();
        public abstract bool CzyUtonie();
    }

    class Samochod : Pojazd
    {
        public override bool CzyMaDach()
        {
            return true;
        }
        public override bool CzyToWieloslad()
        {
            return true;
        }
        public override bool CzyUtonie()
        {
            return true;
        }
    }

    class Rower : Pojazd
    {
        public override bool CzyMaDach()
        {
            return false;
        }
        public override bool CzyToWieloslad()
        {
            return false;
        }
        public override bool CzyUtonie()
        {
            return true;
        }
    }

    class Lodz : Pojazd
    {
        public override bool CzyMaDach()
        {
            return false;
        }
        public override bool CzyToWieloslad()
        {
            return false;
        }
        public override bool CzyUtonie()
        {
            return false;
        }
    }
}
