using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Count_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] massive = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            decimal digit = decimal.Parse(Console.ReadLine());
            int ccount = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                if (digit < massive[i])
                {
                    ccount++;
                }
            }
            Console.WriteLine(ccount);
        }
    }
}