﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
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
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.averageGrade = sum / ratings.Count;
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();
            
            return stats;
        }
    }
}
