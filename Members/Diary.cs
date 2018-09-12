using System;
using System.Collections.Generic;
using System.Linq;

namespace Members
{
    public class Diary
    {
        //Stan (zmienne - pola)
        List<float> ratings = new List<float>();

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }

            set
            {
                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value;

            }
        }

        //Delegat/zdarzenie
        public event NameChangedDelegate NameChanged;

        //Zachowania (metody, którymi będzie dysponować klasa) 

        /// <summary>
        /// Dodaje ocenę do zbioru ocen w Dzienniczku
        /// </summary>
        /// <param name="rating">Nowa ocena</param>
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }

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
