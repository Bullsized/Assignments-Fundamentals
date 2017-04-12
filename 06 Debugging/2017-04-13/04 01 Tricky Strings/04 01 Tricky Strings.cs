using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string currentString = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (i == numberOfStrings - 1)
                {
                    result += currentString;
                    break;
                }
                result += currentString + delimiter;
            }
            Console.WriteLine(result);
        }
    }
}