using System;
using System.Collections.Generic;
using System.Linq;

namespace Episode13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Najważniejsza część odcinka tworzenie nowego obiektu przez użycie konstruktora domyslnego!!!
            Diary diary = new Diary();
            Diary diary1 = new Diary();
            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();

            //dodawanie ocen "na sztywno"
            diary.AddRating(5);
            diary.AddRating(7);

            Console.WriteLine("To jest wywołanie metody/pola static, która nie potrzebuje tworzenia obiektu: " + Diary.minGrade);
            Console.WriteLine("To jest wywołanie metody/pola static, która zlicza liczbę obiektów: " + Diary.count);
            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Srednia Twoich ocen to: " + stats.averageGrade);
            Console.WriteLine("Najwyższa ocena to: " + stats.maxGrade);
            Console.WriteLine("Najniższa ocena to: " + stats.minGrade);
            Console.ReadKey();
        }
    }
}
