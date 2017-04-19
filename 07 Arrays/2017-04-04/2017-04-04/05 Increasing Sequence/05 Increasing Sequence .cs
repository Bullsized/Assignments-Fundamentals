using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool lamp = false;

            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i] < massive[i - 1])
                {
                    lamp=true;
                    break;
                }
            }
            if (lamp == true)
            {
                Console.WriteLine("No");
            }
            else
            { Console.WriteLine("Yes"); }
        }
    }
}