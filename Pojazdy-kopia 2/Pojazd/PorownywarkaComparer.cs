using System.Collections.Generic;

namespace Porownywarka
{
    class PorownywarkaComparer : IComparer<Pojazd>
    {
        private IPorownywarka porownywarka;

        public PorownywarkaComparer(IPorownywarka porownywarka)
        {
            this.porownywarka = porownywarka;
        }

        public int Compare(Pojazd x, Pojazd y)
        {
            return porownywarka.PorownajPojazd(x, y);
        }
    }

}
