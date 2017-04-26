using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestDigit = int.MaxValue;

            foreach (int digit in arrayOfDigits)
            {
                if (digit < smallestDigit)
                {
                    smallestDigit = digit;
                }
            }

            Console.WriteLine(smallestDigit);
        }
    }
}