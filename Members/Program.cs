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
            diary.AddRating(7);
            diary.AddRating(8);
            diary.AddRating(4.5f);
            diary.AddRating(8.9f);

            //Aby wywołać dwu delegatów bez nadpisania metody należy zastosować operator +=
            diary.NameChanged += new NameChangedDelegate(OnNameChanged);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged2);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged3);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged4);

            DiaryStatistics stats = diary.ComputeStatistics();

            //WriteResult("średnia",stats.averageGrade);
            //WriteResult("Max", (int)stats.maxGrade,1);
            //WriteResult("Minimum",stats.minGrade);
            diary.Name = "Dziennik Icka";
            diary.Name = "Dziennik Zuzi";
            
            Console.Write(diary.Name);
            Console.ReadKey();
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Zmiana nazwy z {existingName} na {newName}");
        }

        private static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("******************************************");
        }

        private static void OnNameChanged3(string existingName, string newName)
        {
            Console.WriteLine("???????????????????????????????????????????");
        }

        private static void OnNameChanged4(string existingName, string newName)
        {
            Console.WriteLine("//////////////////////////////////////////////");
        }
    }
}
