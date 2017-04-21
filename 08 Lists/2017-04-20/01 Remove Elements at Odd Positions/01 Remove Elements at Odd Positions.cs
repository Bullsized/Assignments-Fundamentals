using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<string> answer = new List<string>();
            
            for (int cycle = 1; cycle < words.Count; cycle+=2)
            {
                answer.Add(words[cycle]);
            }

            Console.WriteLine(string.Join("", answer));
        }
    }
}