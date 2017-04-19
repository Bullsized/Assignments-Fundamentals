using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            string[] result = input.Split();

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write (double.Parse(result[i]) * p + " ");
            }
        }
    }
}