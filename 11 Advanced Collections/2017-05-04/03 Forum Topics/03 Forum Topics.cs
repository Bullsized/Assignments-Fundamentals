using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Dictionary<string, HashSet<string>>();
            string inputTopicsAndTags = Console.ReadLine();

            while (inputTopicsAndTags != "filter")
            {
                string[] topicsAndTags = inputTopicsAndTags.Split(new char[] { ' ', ',', '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string initialTopic = topicsAndTags[0];

                if (!solution.ContainsKey(initialTopic))
                {
                    solution[initialTopic] = new HashSet<string>();
                }
                for (int cycle = 1; cycle < topicsAndTags.Length; cycle++)
                {
                    solution[initialTopic].Add(topicsAndTags[cycle]);
                }

                inputTopicsAndTags = Console.ReadLine();
            }

            string[] filterByWords = Console.ReadLine().Split(new char[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            bool trulyContains = false;
            int count = 0;

            foreach (var kvp in solution)
            {
                count = 0;
                for (int cycle2 = 0; cycle2 < filterByWords.Length; cycle2++)
                {
                    for (int cycle3 = 0; cycle3 < kvp.Value.Count; cycle3++)
                    {
                        if (kvp.Value.Contains(filterByWords[cycle2]))
                        {
                            trulyContains = true;
                            count++;
                            break;
                        }
                        else
                        {
                            trulyContains = false;
                            break;
                        }
                    }
                    if (!trulyContains)
                    {
                        break;
                    }
                }
                if (trulyContains && count == filterByWords.Length)
                {
                    Console.WriteLine($"{kvp.Key} | #{string.Join(", #", kvp.Value)}");
                }
            }

            //2nd method to print out the answer:
            //foreach (var kvp in solution)
            //{
            //    bool contains = true;
            //    foreach (var filter in filterByWords)
            //    {
            //        if (kvp.Value.Contains(filter))
            //        {
            //            contains = false;
            //        }
            //    }

            //    if (contains)
            //    {
            //        Console.WriteLine($"{kvp.Key} | #{string.Join(", #", kvp.Value)}");
            //    }
            //}
        }
    }
}