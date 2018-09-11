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

            DiaryStatistics stats = diary.ComputeStatistics();

            //WriteResult("średnia",stats.averageGrade);
            //WriteResult("Max", (int)stats.maxGrade,1);
            //WriteResult("Minimum",stats.minGrade);
            diary.Name = "Dziennik Icka";
            diary.Name = "";
            
            Console.Write(diary.Name);
            Console.ReadKey();
        }

        //przykłady overloadingu
        static void WriteResult(string description,params float[] result)
        {
            Console.WriteLine(description + ": " + result[0] + " " + result[1]);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
