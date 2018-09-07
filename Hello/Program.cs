using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            valueTypes();

            for (; ; )
            {
                PodajImie();
                PodajWiek();
                Ustawienia();
            }
        }

        private static void valueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt= " + maxInt);
            Console.WriteLine("minInt= " + minInt);
            Console.WriteLine("maxLong= " + maxLong);
            Console.WriteLine("minLong= " + minLong);
        }

        /// <summary>
        /// Czyści konsolę do stanu 0
        /// </summary>
        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        
        /// <summary>
        /// Wypisujemy komunikat zależny od podanego wieku użytkownika
        /// </summary>
        private static void PodajWiek()
        {
            Console.Write("Podaj swój wiek: ");
            bool result = int.TryParse(Console.ReadLine(), out int age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Jesteś pełnoletni. Możesz wypić piwsko.");
            }
            else if (result == false)
            {
                Console.WriteLine("Wiek jest podany niepoprawnie.");
            }
            else
            {
                Console.WriteLine("Dla Ciebie Młody kawalerze mamy mleko.");
            }
        }

        /// <summary>
        /// Wypisujemy imię użytkownika
        /// </summary>
        private static void PodajImie()
        {
            Console.Write("Wpisz swoje Imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}