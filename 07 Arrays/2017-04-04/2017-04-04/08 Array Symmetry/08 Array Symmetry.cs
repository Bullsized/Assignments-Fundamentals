using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massive = Console.ReadLine().Split(' ');

            // 1 2 3 3 2 1
            int index = 0;
            bool lamp = false;

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] != massive[massive.Length - 1 - index])
                {
                    Console.WriteLine("No");
                    lamp = true;
                    break;
                }
                index++;
            }
            if (lamp == false)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}