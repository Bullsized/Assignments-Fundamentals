using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(FindNthDigit(number, index)));
        }

        static int FindNthDigit (long number, int index)
        {
            int count = 0;
            long result = 0;
            while (number != 0)
            {
                count++;
                number /= 10;
                if (count + 1 == index)
                {
                    result = number % 10;
                }
            }
            return (int)result;
        }
    }
}