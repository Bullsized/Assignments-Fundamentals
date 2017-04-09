using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeRepeated = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(toBeRepeated, times));
        }
        static string RepeatString(string toBeRepeated, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result += toBeRepeated;
            }
            return result;
        }
    }
}