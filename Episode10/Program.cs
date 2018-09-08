using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode10
{
    class Program
    {
        static void Main(string[] args)
        {
            //przypisanie zmiennej obiektowej (typu referncyjnego/złożonego) do innej zmiennej obiektowej
            //powoduje, że obydwie przekazują jeden i ten sam obiekt
            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary2 = diary;
            diary2.AddRating(8);

        }
    }
}
