using System;

namespace LapanieWyjatkow
{
    class MojException : Exception
    {
        public MojException(string message) : base(message)
        {

        }
    }

    class TestMojegoWyjatku
    {
        public void Test()
        {
            Random random = new Random();
            double randomDouble1 = random.NextDouble() * (1.0 - 0.0) + 0.0;
            double randomDouble2 = random.NextDouble() * (1.0 - 0.0) + 0.0;

            double sumaKw = randomDouble1 * randomDouble1 + randomDouble2 + randomDouble2;
            if(sumaKw < 1)
            {
                throw new MojException("Suma Kwadratow jest mniejsza od 1");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            LapanieWyjatkow a = new LapanieWyjatkow();

            int[] arr1 = new int[] { 11, 2, 3, 4 };

            try
            {
                a.Podziel(arr1);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e.ToString());
            }
            */

            TestMojegoWyjatku t = new TestMojegoWyjatku();

            for(int i=0; i<5; i++)
            {
                try
                {
                    t.Test();
                }
                catch (MojException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
