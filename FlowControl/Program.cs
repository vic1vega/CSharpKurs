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
        private static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię: ");
            name = Console.ReadLine();

            //IfInstruction();
            //SwitchInstruction();

            //LoopInstruction
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Wartość i: {i}");
            }

            int i1 = 1;
            while (i1 > 2)
            {
                i1++;
                Console.WriteLine("Hello");
            }

            do
            {
                i1++;
                Console.WriteLine("Hello");
            } while (i1 > 3);

            int[] arrs = { 1, 2, 3, 4, 5 };
            foreach (var arr in arrs)
            {
                Console.WriteLine(arr);
            }
            
            //pętla nieskończona
            for (; ; )
            {
                Console.WriteLine("Inf Loop");
            }

            Console.ReadKey();
        }

        private static void SwitchInstruction()
        {
            //switchInstruction
            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    break;
                default:
                    Method4();
                    break;
            }
        }

        private static void IfInstruction()
        {
            //Instrukcje if
            Console.WriteLine("Podaj wiek: ");
            age = int.Parse(Console.ReadLine());

            if (age <= 10)
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
