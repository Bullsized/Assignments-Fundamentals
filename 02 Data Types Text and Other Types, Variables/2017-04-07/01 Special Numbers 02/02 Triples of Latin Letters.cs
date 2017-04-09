using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Special_Numbers_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter = int.Parse(Console.ReadLine());

            for (int i = 0; i < letter; i++)
            {
                for (int j = 0; j < letter; j++)
                {
                    for (int k = 0; k < letter; k++)
                    {
                        Console.WriteLine($"{(char)(i + 'a')}{(char)(j + 'a')}{(char)(k + 'a')}");
                    }
                }
            }
        }
    }
}