using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();

            numbers.Reverse();

            List<char> answer = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                foreach (char letter in numbers[i])
                {
                    if (letter >= 48 && letter <= 57)
                    {
                        answer.Add(letter);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}