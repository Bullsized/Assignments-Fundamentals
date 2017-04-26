﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listToBeSorted = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int howManyDigitsToDisplay = int.Parse(Console.ReadLine());
            bool bubbleSwap = false;

            do
            {
                bubbleSwap = false;

                for (int sortingCycle = 0; sortingCycle < listToBeSorted.Count - 1; sortingCycle++)
                {
                    int firstDigit = listToBeSorted[sortingCycle];
                    int secondDigit = listToBeSorted[sortingCycle + 1];

                    if (firstDigit < secondDigit)
                    { 
                        listToBeSorted[sortingCycle] = secondDigit;
                        listToBeSorted[sortingCycle + 1] = firstDigit;
                        bubbleSwap = true;
                    }
                }
            } while (bubbleSwap);

            for (int resultCycle = 0; resultCycle < howManyDigitsToDisplay; resultCycle++)
            {
                Console.Write(listToBeSorted[resultCycle] + " ");
            }
        }
    }
}