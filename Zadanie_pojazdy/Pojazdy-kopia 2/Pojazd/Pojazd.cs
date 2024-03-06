

namespace Porownywarka
{
    abstract class Pojazd
    {
        public int miejsca;
        public int kola;
        public int cena;
        public int waga;

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

 
}
