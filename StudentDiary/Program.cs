using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Najważniejsza część odcinka tworzenie nowego obiektu przez użycie konstruktora domyslnego!!!
            Diary diary = new Diary();
                        
            //dodawanie ocen "na sztywno"
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);
            //diary.AddRating(7);
            //diary.AddRating(3.8f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GetMaxRating();
            //float min = diary.GetMinRating();

            //dodawanie ocen przez użytkownika
            for (; ;)
            {
                Console.WriteLine("Podaj ocenę (1-10)");
                bool result = float.TryParse(Console.ReadLine(), out float rating);

                if (rating > 10)
                {
                    break;
                }
                if (result) //to samo co (result == true)
                {
                    diary.AddRating(rating);
                }
                
            }

            Console.WriteLine("Srednia Twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GetMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GetMinRating());
            Console.ReadKey();
        }
    }
}
