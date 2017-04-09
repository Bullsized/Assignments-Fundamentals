using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(first, second, third));
        }

        static int GetMin(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                return first;
            }
            else if (second < first && second < third)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}