using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double digit = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(PowerOfMath(digit, power));
        }

        static double PowerOfMath(double digit, double power)
        {
            return Math.Pow(digit, power);
        }
    }
}