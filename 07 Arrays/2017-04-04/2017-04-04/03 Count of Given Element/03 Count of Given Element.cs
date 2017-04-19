using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Count_of_Given_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());
            int ccount = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                if (num == massive[i])
                {
                    ccount++;
                }
            }
            Console.WriteLine(ccount);
        }
    }
}