﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                newArray[i] = m;
                sum += newArray[i];
            }
            Console.WriteLine(sum);
        }
    }
}