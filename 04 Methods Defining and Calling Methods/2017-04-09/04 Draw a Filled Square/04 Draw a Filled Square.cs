using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderAndFooter(n);
            PrintFilling(n);
            PrintHeaderAndFooter(n);
        }

        static void PrintHeaderAndFooter(int n)
        {
            Console.WriteLine(new string('-', 2*n));
        }
        static void PrintFilling(int n)
        {
            for (int mid = 0; mid < n - 2; mid++)
            {
                Console.Write("-");
                for (int V = 0; V < n - 1; V++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}