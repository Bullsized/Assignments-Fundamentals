using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbolz = Console.ReadLine().ToCharArray();
            int[] numbz = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbz.Length; i++)
            {
                if (numbz[i] %2 == 0)
                {
                    symbolz[i] -= (char)numbz[i];
                }
                else if (numbz[i] %2 != 0)
                {
                   symbolz[i] += (char)numbz[i];
                }
            }
            for (int i = 0; i < symbolz.Length; i++)
            {
                Console.Write(symbolz[i]);
            }
            Console.WriteLine();
        }
    }
}