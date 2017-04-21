﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> givenNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> rotatedNumbers = new List<int>(givenNumbers.Count);

            rotatedNumbers.Add(givenNumbers[0]);
            
            for (int cycle = 1; cycle < givenNumbers.Count - 1; cycle++)
            {
                rotatedNumbers.Add(givenNumbers[givenNumbers.Count - 1 - cycle]);
            }
            rotatedNumbers.Add(givenNumbers[givenNumbers.Count-1]);

            Console.WriteLine(string.Join(" ", rotatedNumbers));
        }
    }
}