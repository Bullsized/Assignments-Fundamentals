using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> realNumbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            SortedDictionary<decimal, int> answer = new SortedDictionary<decimal, int>();

            foreach (var number in realNumbers)
            {
                if (!answer.ContainsKey(number))
                {
                    answer.Add(number, 0);
                }
                answer[number]++;
            }

            foreach (var kvp in answer)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}