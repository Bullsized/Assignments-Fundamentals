using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] massive = new int[n];
            int count = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = int.Parse(Console.ReadLine());
                if (massive [i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
} 