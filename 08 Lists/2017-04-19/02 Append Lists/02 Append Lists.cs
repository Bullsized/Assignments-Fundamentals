using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                 .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                string[] current = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < current.Length; j++)
                {
                    Console.Write(current[j] + " ");
                }
            }
        }
    }
}