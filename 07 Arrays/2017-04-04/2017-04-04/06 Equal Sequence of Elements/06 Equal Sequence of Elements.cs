using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Equal_Sequence_of_Elements
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
                if (massive[i - 1] == massive[i])
                {
                    lamp = true;
                }
                else
                {
                    lamp = false;
                    break;
                }
            }

            if (lamp)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}