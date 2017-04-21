﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = 0;
            int remover = 0;      
            for (int half = digits.Count / 2; half < digits.Count; half += 3)
            {
                for (int cycle = 0; cycle < 2; cycle++)
                {
                    if (cycle == 0)
                    {
                        digits.Insert(index, digits[half] / 10);
                        index += 2;
                    }
                    else
                    {
                        digits.Insert(index, digits[half + 1] % 10);
                        index += 2;
                    }
                }
                index -= 1;
                remover++;
            }
            digits.RemoveRange(digits.Count - remover, remover);
            Console.WriteLine(string.Join(" ", digits));
        }
    }
}