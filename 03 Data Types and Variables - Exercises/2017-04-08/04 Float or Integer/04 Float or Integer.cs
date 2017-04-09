using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());

            if (n % 1 == n)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(Math.Floor(n));
            }
        }
    }
}