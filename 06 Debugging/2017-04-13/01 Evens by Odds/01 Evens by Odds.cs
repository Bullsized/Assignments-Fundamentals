using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            while (numberToRead != 0)
            {
                int dividedDigit = Math.Abs(numberToRead % 10);
                if (dividedDigit % 2 == 0)
                {
                   even += EvenMethod(dividedDigit);
                }
                else
                {
                   odd += OddMethod(dividedDigit);
                }
                numberToRead /= 10;
            }
            Console.WriteLine(even * odd);
        }

        static int EvenMethod (int evenDigit)
        {
            int sumOfEvens = 0;
            sumOfEvens += evenDigit;
            return sumOfEvens;
        }

        static int OddMethod (int oddDigit)
        {
            int sumOfOdds = 0;
            sumOfOdds += oddDigit;
            return sumOfOdds;
        }
    }
}