using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Func()
        {
            int count = 0;
            Random random = new Random();
            for (int x = 0; x <= 15;x++)
            {
                int number = random.Next(-20, 30);
                Console.WriteLine(number);
                if (number >0)
                    count++;
            }
            Console.WriteLine($"count={ count}");
        }
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
