using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SMMAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            List<int> workingList = new List<int>();

            int digitToAdd = 0;

            for (int cycle = 0; cycle < limit; cycle++)
            {
                digitToAdd = int.Parse(Console.ReadLine());

                workingList.Add(digitToAdd);
            }

            Console.WriteLine($"Sum = {workingList.Sum()}");
            Console.WriteLine($"Min = {workingList.Min()}");
            Console.WriteLine($"Max = {workingList.Max()}");
            Console.WriteLine($"Average = {workingList.Average()}");
        }
    }
}