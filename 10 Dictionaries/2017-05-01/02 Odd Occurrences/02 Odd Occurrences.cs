using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            Dictionary<string, int> solution = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!solution.ContainsKey(word))
                {
                    solution[word] = 0;
                }
                solution[word]++;
            }

            List<string> answer = new List<string>();

            foreach (var kvp in solution)
            {
                var value = kvp.Value;
                if (value % 2 == 1)
                {
                    answer.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", answer));
        }
    }
}