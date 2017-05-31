using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> solution = new Dictionary<string, string>();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] inputParams = inputCommand
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                solution[inputParams[0]] = inputParams[1];

                inputCommand = Console.ReadLine();
            }

            inputCommand = Console.ReadLine();

            List<string> containingNull = new List<string>();
            foreach (var kvp in solution)
            {
                if (kvp.Value == "null")
                {
                    containingNull.Add(kvp.Key);
                }
            }

            Dictionary<string, string> realSolution = solution
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in realSolution)
            {
                if (kvp.Value != "null")
                {
                    Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
                }
            }

            foreach (var nullable in containingNull)
            {
                Console.WriteLine($"{nullable} <-> {inputCommand}");
            }
        }
    }
}