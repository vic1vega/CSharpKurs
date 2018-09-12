using System;
using System.Collections.Generic;
using System.Linq;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            try
            {
                Console.WriteLine("Podaj nazwisko osby zakładającej dziennik: ");
                diary.Name = Console.ReadLine();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stos: " + ex.StackTrace);
            }

            diary.AddRating(7);
            diary.AddRating(8);
            diary.AddRating(4.5f);
            diary.AddRating(8.9f);

            //Aby wywołać dwu delegatów/subskrybentów eventu bez nadpisania metody należy zastosować operator +=
            diary.NameChanged += OnNameChanged;
            diary.NameChanged += new NameChangedDelegate(OnNameChanged2);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged3);
            diary.NameChanged -= new NameChangedDelegate(OnNameChanged4);
            diary.NameChanged += null;

            DiaryStatistics stats = diary.ComputeStatistics();

            //WriteResult("średni a",stats.averageGrade);
            //WriteResult("Max", (int)stats.maxGrade,1);
            //WriteResult("Minimum",stats.minGrade);
            diary.Name = "Dziennik Icka";
            diary.Name = "Dziennik Zuzi";
            
            Console.Write(diary.Name);
            Console.ReadKey();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("******************************************");
        }

        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("???????????????????????????????????????????");
        }

        private static void OnNameChanged4(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("//////////////////////////////////////////////");
        }
    }
}
