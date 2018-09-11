using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;



        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek: ");
            age = int.Parse(Console.ReadLine());

            if (age <=10)
            {
                Method1();
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }

            Console.ReadKey();
        }

        private static void Method4()
        {
            Console.WriteLine("Inny wiek");
        }

        private static void Method3()
        {
            Console.WriteLine($"Najwięcej lat {age}");
        }

        private static void Method2()
        {
            Console.WriteLine("Trochę więcej lat");
        }

        private static void Method1()
        {
            Console.WriteLine("Mniej lat");
        }
    }
}
