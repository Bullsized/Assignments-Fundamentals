using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int neededDigit = int.Parse(Console.ReadLine());
            bool lamp = false;

            foreach (int arrayDigit in arrayOfNumbers)
            {
                if (arrayDigit == neededDigit)
                {
                    lamp = true;
                    Console.WriteLine("yes");
                    break;
                }
            }

            if (!lamp)
            {
                Console.WriteLine("no");
            }

        }
    }
}