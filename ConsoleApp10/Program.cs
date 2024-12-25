using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Func()
        {  
            Random random = new Random();
            for (int x = 0; x <= 12;x++)
            {
                int number = random.Next(-50,50);
                if (number == 0)
                    Console.WriteLine($"ноль");
                if (number > 0) Console.WriteLine($"положительное-{number}");
                if (number <0) Console.WriteLine($"отрицательное-{number}");
            }

        }
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
