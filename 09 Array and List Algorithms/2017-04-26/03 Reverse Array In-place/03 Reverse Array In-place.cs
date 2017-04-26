using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToReverse = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int switchedDigit = 0;

            for (int cycle = 0; cycle < arrayToReverse.Length / 2; cycle++)
            {
                switchedDigit = arrayToReverse[cycle];
                arrayToReverse[cycle] = arrayToReverse[arrayToReverse.Length - 1 - cycle];
                arrayToReverse[arrayToReverse.Length - cycle - 1] = switchedDigit;
            }

            Console.WriteLine(string.Join(" ", arrayToReverse));
        }
    }
}