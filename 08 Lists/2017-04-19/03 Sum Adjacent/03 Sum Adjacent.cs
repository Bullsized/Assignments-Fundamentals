using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_Adjacent
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8 2 2 4 8 16
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int loop = 1; loop < numbers.Count; loop++)
            {
                if (numbers[loop - 1] == numbers[loop])
                {
                    numbers[loop] += numbers[loop - 1];
                    numbers.Remove(numbers[loop - 1]);
                    loop = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}