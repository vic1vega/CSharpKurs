﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Episode10
{
    class Diary
    {
        //kontruktor własny
        public Diary()
        {
            ratings = new List<float>();
        }

        //Stan (zmienne - pola)
        List<float> ratings = new List<float>();

        //Zachowania (metody, którymi będzie dysponować klasa) 
        public void AddRating (float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count;
            return avg;
        }

        public float GetMaxRating()
        {
            return ratings.Max();
        }

        public float GetMinRating()
        {
            return ratings.Min();
        }
    }
}
