using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Func()
        {
            int count = 0;
            for (int x = 10; x <= 99; x++)
            {
                if (x % 2 == 0)
                {
                    count++;
                    Console.WriteLine(x);
                }

            }
            Console.WriteLine($"count={count}");
        }
            static void Main(string[] args)
            {
                Func();
                Console.ReadKey();
            }
        
    }
}
