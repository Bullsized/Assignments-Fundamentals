using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string finalResult = string.Empty;
            //   StringBuilder finalTwo = new StringBuilder();

            for (int cycle = 0; cycle < n; cycle++)
            {
                char conditionChar = char.Parse(Console.ReadLine());
                finalResult += GetTheString(conditionChar);
                // finalTwo.  // Append // (GetTheString(conditionChar));
            }

            Console.WriteLine(finalResult);
        }

        private static string GetTheString(char conditionChar)
        {
            int firstDigit = 0;
            int secondDigit = 0;

            string result = string.Empty;

            if (conditionChar >= 100)
            {
                firstDigit = (int)conditionChar / 100;
                secondDigit = (int)conditionChar % 10;
            }
            else
            {
                firstDigit = (int)conditionChar / 10;
                secondDigit = (int)conditionChar % 10;
            }

            int sumCharAndSecondDigit = conditionChar + secondDigit;
            char firstLetter = (char)sumCharAndSecondDigit;

            int substractCharAndFirstDigit = conditionChar - firstDigit;
            char secondLetter = (char)substractCharAndFirstDigit;

            result = $"{firstLetter}{firstDigit}{secondDigit}{secondLetter}";
            return result;
        }
    }
}