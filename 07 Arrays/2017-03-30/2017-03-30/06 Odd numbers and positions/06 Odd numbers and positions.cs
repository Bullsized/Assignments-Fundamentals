using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Odd_numbers_and_positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] %2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {massive[i]}");
                }
            }
        }
    }
}