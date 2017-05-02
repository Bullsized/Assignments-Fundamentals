using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNums = Console.ReadLine()
                .Split(new char[] { ' ',':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            SortedDictionary<string, long> telNums = new SortedDictionary<string, long>();

            while (inputNums[0] != "Over")
            {
                var first = inputNums[0];
                var second = inputNums[1];
                var trueNumber = 0L;

                if (long.TryParse(first, out trueNumber))
                {
                    telNums[second] = trueNumber;
                }
                else
                {
                    telNums[first] = long.Parse(second);
                }

                inputNums = Console.ReadLine()
                .Split(new char[] { ' ',':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            foreach (var kvp in telNums)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}