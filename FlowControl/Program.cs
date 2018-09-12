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
            //LoopInstruction();
            //JumpingInstructions1();
            //int[] ages = {1, 2, 4};
            //JumpingInstructions2(ages);



            Console.ReadKey();
        }

        #region jumpingInstructions
        private static void JumpingInstructions2(int[] ages)
        {
            foreach (int age in ages)
            {
                Console.WriteLine("Wiek wynosi");
                return;
            }
        }

        private static void JumpingInstructions1()
        {
            //JumpingInstruction
            int[] ages = { 1, 2, 4, 78, 20 };

            foreach (int age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine($"Wiek wynosi {age}");
                    continue;
                    Console.WriteLine($"Wiek wynosi {age}, ale jest continue więc nigdy się nie wykona");
                }

                if (age == 4)
                {
                    Console.WriteLine($"Wiek wynosi {age}");
                    break;
                    Console.WriteLine($"Wiek wynosi {age}, ale jest break więc wyjdziemy z pętli");
                }

                if (age == 1)
                {
                    Console.WriteLine($"Wiek wynosi {age}");
                    goto skip;
                    Console.WriteLine($"Wiek wynosi {age}, ale jest goto więc przeskoczy do goto i będzie wykonywać kod od miejsca przeskokou");
                }
            }

            skip:
            Console.WriteLine("Skok kodu na goto");
        }
        #endregion

        private static void LoopInstruction()
        {
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
