using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massive = Console.ReadLine().Split(' ').ToArray();
            bool lamp = false;
            string theWord = "a";

            for (int i = 2; i < massive.Length; i++)
            {
                if (massive[i-2] == massive[i-1] && massive[i-1] == massive[i])
                {
                    theWord = massive[i];
                }
            }

            Console.WriteLine("{0} {1} {2}", theWord, theWord, theWord);
        }
    }
}