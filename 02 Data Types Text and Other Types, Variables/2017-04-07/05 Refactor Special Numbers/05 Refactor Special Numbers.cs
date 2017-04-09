using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitParsed = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            bool lamp = false;

            for (int cycle = 1; cycle <= digitParsed; cycle++)
            {
            int newDigit = cycle;
                while (cycle > 0)
                {
                    sumDigits += cycle % 10;
                    cycle = cycle / 10;
                }

                lamp = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);

                Console.WriteLine($"{newDigit} -> {lamp}");
                sumDigits = 0;
                cycle = newDigit;
            }
        }
    }
}