namespace Porownywarka
{
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
}
