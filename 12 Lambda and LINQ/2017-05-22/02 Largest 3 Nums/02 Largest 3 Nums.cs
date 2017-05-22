using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Largest_3_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> largestList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstDigitsList = largestList.OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(string.Join(" ", firstDigitsList));
        }
    }
}