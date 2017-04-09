using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)

        {
            int number = int.Parse(Console.ReadLine());
            int baseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(TakeBase(number, baseNumber));
        }

        static string TakeBase(int num, int n)
        {
            string result = string.Empty;
            while (num > 0)
            {
                int rem = num % n;
                result = rem + result;
                num /= n;
            }
            return result;
        }
    }
}