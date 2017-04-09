using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Refactor_Volume_of_P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Width: ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("Height: ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Pyramid Volume: {0:f2}", (a * b * c) / 3);
        }
    }
}