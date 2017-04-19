using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_of_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massive = Console.ReadLine()
                .Split(' ');
            int ccount = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                string currentWord = massive[i];
                if (currentWord.Length == 1)
                {
                    char currentChar = currentWord[0];
                    if (currentChar >= 65 && currentChar <= 90)
                    {
                        ccount++;
                    }
                }
            }
            Console.WriteLine(ccount);
        }
    }
}