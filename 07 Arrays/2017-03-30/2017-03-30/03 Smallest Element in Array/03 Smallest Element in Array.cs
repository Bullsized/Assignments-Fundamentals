using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int minNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (minNum > numbers[i])
                {
                    minNum = numbers[i];
                }
            }
            Console.WriteLine(minNum);

          //  var minimuma = numbers.Min();
          //  Console.WriteLine(minimuma);
        }
    }
}