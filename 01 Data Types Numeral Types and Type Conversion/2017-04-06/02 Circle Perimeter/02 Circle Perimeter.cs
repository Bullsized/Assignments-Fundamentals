using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Circle_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = radius * Math.PI * 2;
            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}