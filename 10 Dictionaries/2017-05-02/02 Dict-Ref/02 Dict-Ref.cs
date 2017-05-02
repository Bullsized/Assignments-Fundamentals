using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> answer = new Dictionary<string, int>();

            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "end")
            {

                var first = input[0];
                var last = input[1];
                int number = 0;

                if (int.TryParse(last, out number))
                {
                    answer[first] = number;
                }
                else
                {
                    if (answer.ContainsKey(last))
                    {
                        var refValue = answer[last];
                        answer[first] = refValue;
                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            
            foreach (var kvp in answer)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}