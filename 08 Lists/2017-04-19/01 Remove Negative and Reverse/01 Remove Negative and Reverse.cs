using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Negative_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int cyc = 0; cyc < numbers.Count; cyc++)
            {
                if (numbers[cyc] < 0)
                {
                    numbers.Remove(numbers[cyc]);
                    cyc--;
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                for (int cyc2 = 0; cyc2 < numbers.Count; cyc2++)
                {
                    Console.Write("{0} ", numbers[cyc2]);
                }
            }
        }
    }
}