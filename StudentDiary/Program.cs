using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Najważniejsza część odcinka tworzenie nowego obiektu przez użycie konstruktora domyslnego!!!
            Diary diary = new Diary();

            //dodawanie ocen "na sztywno"
            diary.AddRating(5);
            diary.AddRating(7);


            DiaryStatistics stats = diary.ComputeStatistics();

            SpeakData(stats);

            Console.WriteLine("Srednia Twoich ocen to: " + stats.averageGrade);
            Console.WriteLine("Najwyższa ocena to: " + stats.maxGrade);
            Console.WriteLine("Najniższa ocena to: " + stats.minGrade);
            Console.ReadKey();
        }

        private static void SpeakData(DiaryStatistics stats)
        {
            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt.Speak("Srednia Twoich ocen to: " + stats.averageGrade);
        }
    }
}
