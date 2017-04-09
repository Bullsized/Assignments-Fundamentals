using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exchange_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            Console.WriteLine($"{a}\n{c}");

            //for stupid assignments, stupid name holders.
        }
    }
}