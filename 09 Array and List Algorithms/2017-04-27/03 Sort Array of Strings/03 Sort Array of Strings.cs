using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sortingList = Console.ReadLine().Split(' ').ToList();
            bool bubbleLamp = false;

            do
            {
                bubbleLamp = false;
                for (int cycle = 0; cycle < sortingList.Count - 1; cycle++)
                {
                    string first = sortingList[cycle];
                    string second = sortingList[cycle + 1];
                    var sort = sortingList[cycle].CompareTo(sortingList[cycle + 1]);
                    if (sort == -1)
                    {
                        sortingList[cycle] = second;
                        sortingList[cycle + 1] = first;
                        bubbleLamp = true;
                    }
                }
            } while (bubbleLamp);

            sortingList.Reverse();

            Console.WriteLine(string.Join(" ", sortingList));
        }
    }
}