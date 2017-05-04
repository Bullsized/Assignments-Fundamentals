using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCityShells = Console.ReadLine();

            var solution = new Dictionary<string, List<int>>();

            inputCityShells = SortingRegionsAndSizes(inputCityShells, solution);
            
            PrintTheSolution(solution);

        }

        static string SortingRegionsAndSizes(string inputCityShells, Dictionary<string, List<int>> solution)
        {
            while (inputCityShells != "Aggregate")
            {
                string[] arrayToSolution = inputCityShells.Split().ToArray();
                string region = arrayToSolution[0];
                int size = int.Parse(arrayToSolution[1]);

                if (!solution.ContainsKey(region))
                {
                    solution.Add(region, new List<int>());
                }
                if (!solution[region].Contains(size))
                {
                    solution[region].Add(size);
                }

                inputCityShells = Console.ReadLine();
            }

            return inputCityShells;
        }

        private static void PrintTheSolution(Dictionary<string, List<int>> solution)
        {
            foreach (var region in solution)
            {
                int giantShell = (region.Value.Sum() - ((region.Value.Sum()) / region.Value.Count));

                Console.Write($"{region.Key} -> ");

                Console.WriteLine($" {string.Join(", ", region.Value)} ({giantShell})");
            }
        }
    }
}