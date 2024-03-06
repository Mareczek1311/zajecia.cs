namespace Porownywarka
{
    interface IPorownywarka
    {
        public int PorownajPojazd(Pojazd a, Pojazd b);
    }



    class IloscMiejscPorownywarka : IPorownywarka{
        public int PorownajPojazd(Pojazd x, Pojazd y)
        {
            if(x.miejsca < y.miejsca)
            {
                return 1;
            }
            return 0;
        }
    }

    class WagaPorownywarka : IPorownywarka
    {
        public int PorownajPojazd(Pojazd x, Pojazd y)
        {
            if(x.waga < y.waga)
            {
                return 1;
            }
            return 0;
        }
    }

}
