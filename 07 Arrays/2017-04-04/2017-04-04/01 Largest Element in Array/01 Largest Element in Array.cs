using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] massive = new int[n];
            int biggest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                massive[i] = int.Parse(Console.ReadLine());
                if (massive[i] > biggest)
                {
                    biggest = massive[i];
                }
            }
            Console.WriteLine(biggest);
        }
    }
}