using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sort_Array_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToBeSorted = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool swapped = false;
           
            do
            {
                swapped = false;
                for (int cycle = 0; cycle < arrayToBeSorted.Length - 1; cycle++)
                {
                    int currentElement = arrayToBeSorted[cycle];
                    int nextElement = arrayToBeSorted[cycle + 1];

                    if (currentElement > nextElement)
                    {
                        arrayToBeSorted[cycle + 1] = currentElement;
                        arrayToBeSorted[cycle] = nextElement;
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", arrayToBeSorted));
        }
    }
}