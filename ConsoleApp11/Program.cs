using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Func()
        {
            Random random = new Random();
            for (int x = 0; x < 8; x++)
            {
                int number = random.Next(-30, 30);
                if (number == 0)
                    Console.WriteLine($"ноль");
                if (number > 0)
                {
                    Console.Write("положительное, ");
                }
                else
                {
                    Console.Write("отрицательное, ");
                }


                if (number % 2 == 0)
                {
                    Console.Write("чётное = ");
                }
                else
                {
                    Console.Write("нечётное = ");
                }
                Console.WriteLine(number);
            }

        }

        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
