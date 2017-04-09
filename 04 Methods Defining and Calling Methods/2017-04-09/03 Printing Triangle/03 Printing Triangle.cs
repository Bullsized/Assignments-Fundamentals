using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TrianglePrint(n);
        }

        static void TrianglePrint(int n)
        {
            for (int cyc1 = 1; cyc1 <= n; cyc1++)
            {
                for (int cyc2 = 1; cyc2 <= cyc1; cyc2++)
                {
                    Console.Write(cyc2 + " ");
                }
                Console.WriteLine();
            }

            for (int cyc3 = 1; cyc3 <= n - 1; cyc3++)
            {
                for (int cyc4 = 1; cyc4 <= n - cyc3; cyc4++)
                {
                    Console.Write(cyc4 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}