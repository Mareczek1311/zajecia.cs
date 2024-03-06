using System;

namespace Pojazd
{
    abstract class Pojazd : IComparable<Pojazd>
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

        public int CompareTo(Pojazd other)
        {
            return this.GetType().Name.CompareTo(other.GetType().Name);
        }

        public override string ToString()
        {
            return $"Pojazd: {this.GetType().Name}";
        }


        public abstract bool CzyToWieloslad();
        public abstract bool CzyMaDach();
        public abstract bool CzyUtonie();
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

    class Program
    {
        static void Main(string[] args)
        {
            Pojazd[] pojazdy = new Pojazd[]
            {
                new Samochod(),
                new Rower(),
                new Rower(),
                new Lodz(),
                new Samochod()
            };

            Array.Sort(pojazdy);

            for(int i=0; i<pojazdy.Length; i++)
            {
                Console.WriteLine(pojazdy[i].ToString());
            }

        }
    }
}
