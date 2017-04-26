using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayToBeSorted = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int currentElement = 0; currentElement < arrayToBeSorted.Count - 1; currentElement++)
            {
                int nextElement = currentElement + 1;
                while (nextElement > 0)
                {
                    if (arrayToBeSorted[nextElement] < arrayToBeSorted[nextElement - 1])
                    {
                        int tempDigit = arrayToBeSorted[nextElement];
                        arrayToBeSorted[nextElement] = arrayToBeSorted[nextElement - 1];
                        arrayToBeSorted[nextElement - 1] = tempDigit;
                    }
                    nextElement--;
                }
            }

            Console.WriteLine(string.Join(" ", arrayToBeSorted));
        }
    }
}