using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] word = new char[n];
            for (int i = 0; i < n; i++)
            {
                int letters = int.Parse(Console.ReadLine());
                word[i] = (char)letters;
            }
            for (int m = 0; m < n; m++)
            {
                Console.Write(word[m]);
            }
            Console.WriteLine();
        }
    }
}