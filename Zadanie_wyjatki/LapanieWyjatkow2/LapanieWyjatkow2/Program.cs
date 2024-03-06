using System;

namespace LapanieWyjatkow2
{

    class PrzedzialException : Exception
    {
        public double Poczatek;
        public double Koniec;
        public Func<double, double> Funkcja { get; private set; }


        public PrzedzialException(double poczatek, double koniec, Func<double, double> funkcja, string message) : base(message)
        {
            Poczatek = poczatek;
            Koniec = koniec;
            Funkcja = funkcja;
        }
    }

    class SzukajPierwiastka
    {
        public static void Szukaj(Func<double, double> funkcja, double lewy, double prawy, double dokladnosc)
        {

            double srodek = (lewy + prawy) / 2;

            try
            {
                if (prawy - lewy < dokladnosc)
                {
                    Console.WriteLine($"Pierwiastek znajduje się w przedziale: [{lewy}, {prawy}]");
                    return;
                }

                Testuj(funkcja, lewy, srodek, dokladnosc);

                Testuj(funkcja, srodek, prawy, dokladnosc);
            }
            catch (PrzedzialException e)
            {
                Szukaj(e.Funkcja, e.Poczatek, e.Koniec, dokladnosc);
            }

        }

        public static void Testuj(Func<double, double> funkcja, double lewy, double prawy, double dokladnosc)
        {
            if(funkcja(lewy) * funkcja(prawy) > 0)
            {
                throw new PrzedzialException(lewy, prawy, funkcja, "Funckja nie ma roznych znakow");
            }

            if(funkcja(lewy) == 0 || funkcja(prawy) == 0)
            {
                throw new PrzedzialException(lewy, prawy, funkcja, "Funckja przyjmuje wartosc 0");
            }

            double srodek = (lewy + prawy) / 2;

            if (prawy - lewy < dokladnosc)
            {
                Console.WriteLine($"Pierwiastek znajduje się w przedziale: [{lewy}, {prawy}]");
                return;
            }

            // Jeśli funkcja ma różne znaki na lewym krańcu i środku przedziału, wypisujemy informację o znalezionym pierwiastku
            if (funkcja(lewy) * funkcja(srodek) < 0)
            {
                Console.WriteLine($"Pierwiastek znajduje się w przedziale: [{lewy}, {srodek}]");
            }
            // W przeciwnym razie wypisujemy informację o znalezionym pierwiastku dla prawej połowy
            else
            {
                Console.WriteLine($"Pierwiastek znajduje się w przedziale: [{srodek}, {prawy}]");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> funkcja = x => x * x * x - 2 * x * x - x + 2;

            try
            {
                Console.WriteLine("Wyszukiwanie pierwiastka metodą połowienia:");
                SzukajPierwiastka.Szukaj(funkcja, -2, 2, 0.0001);
            }
            catch (PrzedzialException ex)
            {
                Console.WriteLine($"Wyjątek PrzedzialException: {ex.Message}. Przedział: [{ex.Poczatek}, {ex.Koniec}].");
            }
        }
    }
}
