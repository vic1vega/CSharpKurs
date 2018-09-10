using System;
using System.Collections.Generic;
using System.Linq;

namespace Types
{
    class Program
    {
        //przekazywanie referencji
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name  = " Nowy dziennik Marcina";
        }

        //przekazywanie wartości
        static int IncreamentNumber(int number)
        {
            number += 1;
            return number;
        }

        static void Main(string[] args)
        {
            ////Najważniejsza część odcinka tworzenie nowego obiektu przez użycie konstruktora domyslnego!!!
            //Diary diary = new Diary();

            ////dodawanie ocen "na sztywno"
            //diary.AddRating(5);
            //diary.AddRating(7);


            //DiaryStatistics stats = diary.ComputeStatistics();

            //Console.WriteLine("Srednia Twoich ocen to: " + stats.averageGrade);
            //Console.WriteLine("Najwyższa ocena to: " + stats.maxGrade);
            //Console.WriteLine("Najniższa ocena to: " + stats.minGrade);
            //Console.ReadKey();

            //PassBValueAndRef();

            //Immutable();

            Arrays();


            //string name1 = "Marcin";
            //string name2 = "marcin";
            ////pokazanie enumeracji na metodzie stringcomparision
            //bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            //Console.WriteLine(areEqual);

            Console.Write("Press any key to quit...");
            Console.ReadKey();

        }

        private static void Arrays()
        {
            float[] ratings = new float[5];

            AddRatings(ratings);
            
            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }
        }

        private static void AddRatings(float[] rateings)
        {
            if (rateings.Length >= 4)
            {
                rateings[0] = 4.2f;
                rateings[1] = 3.2f;
                rateings[2] = 0.2f;
                rateings[3] = 8.2f;

            }
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2018, 3, 10);
            date = date.AddHours(48);

            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PassBValueAndRef()
        {
            //przykład dla typów referencyjnych
            Diary diary1 = new Diary();
            Diary diary2 = diary1;

            //implementacja metody z parametrem typu referencyjnego
            GiveName(ref diary1);

            Console.WriteLine("Nazwa dziennika 2: " + diary2.Name);

            int x1 = 4;

            //implementacja metody z parametrem typu wartościowego
            x1 = IncreamentNumber(x1);
        }
    }
}
