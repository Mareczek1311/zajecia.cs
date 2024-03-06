using System;

namespace LapanieWyjatkow
{
    class LapanieWyjatkow
    {
        public void Podziel(int[] arr)
        {
            try
            {
                int iloczyn = 1;

                for (int i = 0; i < arr.Length; i++)
                {
                    iloczyn *= arr[i];
                }

                Console.WriteLine("Iloczyn: " + iloczyn);

                checked {
                    arr[0] = arr[0] + arr[1] * arr[2] * arr[3] / arr[4];
                }

                Console.WriteLine("Liczba: " + arr[0]);

            }
            catch(NullReferenceException e)
            {
                throw e;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DIVIDE BY ZERO" + e.ToString());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(" INDEX OUT OF RANGE" +e.ToString());
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OVERFLOW: " + e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
