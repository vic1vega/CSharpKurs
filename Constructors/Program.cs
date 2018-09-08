using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //przykład wykorzystania poszczególnych konstruktorów ustalonych w klasie Person
            Person person = new Person();
            Person person2 = new Person(1, "Krzysiek", "Iksiński");
            Person person3 = new Person(2, "Hubert", "Iksiński", "Katowice", 18, "Kobieta");
        }
    }
}
