using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] indexes = new int[numbers.Max() + 1];

            for (int cycle = 0; cycle < numbers.Length; cycle++)
            {
                indexes[numbers[cycle]]++;
            }

            for (int cycle2 = 0; cycle2 < indexes.Length; cycle2++)
            {
                if (indexes[cycle2] > 0)
                {
                    Console.WriteLine($"{cycle2} -> {indexes[cycle2]}");
                }
            }
        }
    }
}