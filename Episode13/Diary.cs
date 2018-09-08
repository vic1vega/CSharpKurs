using System;
using System.Collections.Generic;
using System.Linq;

namespace Episode13
{
    class Diary
    {
        //Stan (zmienne - pola)
        List<float> ratings = new List<float>();
        
        //Zachowania (metody, którymi będzie dysponować klasa) 

        /// <summary>
        /// Dodaje ocenę do zbioru ocen w Dzienniczku
        /// </summary>
        /// <param name="rating">Nowa ocena</param>
        public void AddRating (float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Oblicza statystyki wyseparowane do klasy DiaryStatistics
        /// </summary>
        /// <returns></returns>
        public DiaryStatistics ComputeStatistics()
        {
            float sum = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            DiaryStatistics stats1 = new DiaryStatistics();
            stats1.averageGrade = sum / ratings.Count;
            stats1.maxGrade = ratings.Max();
            stats1.minGrade = ratings.Min();

            return stats1;
        }
    }
}
