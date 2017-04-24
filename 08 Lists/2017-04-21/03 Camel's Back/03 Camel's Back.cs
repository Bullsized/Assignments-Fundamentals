﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> topOfTheCamel = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelsBack = int.Parse(Console.ReadLine());

            if (camelsBack == topOfTheCamel.Count)
            {
                Console.WriteLine("already stable: " + string.Join(" ", topOfTheCamel));
            }
            else
            {
                int roundsPassed = (topOfTheCamel.Count - camelsBack) / 2;
                int zeroIndex = 0;
                for (int cycle = 0; cycle < roundsPassed; cycle++)
                {                 
                    topOfTheCamel.RemoveAt(zeroIndex);
                    topOfTheCamel.RemoveAt(topOfTheCamel.Count-1);
                }
                Console.WriteLine($"{roundsPassed} rounds\nremaining: " + string.Join(" ", topOfTheCamel));
            }
        }
    }
}