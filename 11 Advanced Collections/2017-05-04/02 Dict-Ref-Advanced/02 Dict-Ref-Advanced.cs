using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var personAndGrades = new Dictionary<string, List<int>>();

            string inputPersonAndGrades = Console.ReadLine();

            while (inputPersonAndGrades != "end")
            {
                string[] toAddToTheDict = inputPersonAndGrades.Split(new char[] { '-', '>', ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string personName = toAddToTheDict[0];

                int wrongPerson = 0;

                bool seeIfItIsTheWrongPerson = int.TryParse(toAddToTheDict[1], out wrongPerson);

                if (seeIfItIsTheWrongPerson)
                {
                    if (!personAndGrades.ContainsKey(personName))
                    {
                        personAndGrades[personName] = new List<int>();
                    }
                        for (int cycle = 1; cycle < toAddToTheDict.Length; cycle++)
                        {
                            int tryToParseForList = 0;
                            var checkIfDigit = int.TryParse(toAddToTheDict[cycle], out tryToParseForList);
                            personAndGrades[personName].Add(tryToParseForList);
                        }
                }
                else
                {
                    if (!personAndGrades.ContainsKey(toAddToTheDict[1]))
                    {
                        inputPersonAndGrades = Console.ReadLine();
                        continue;
                    }

                    if (!personAndGrades.ContainsKey(personName))
                    {
                        personAndGrades[personName] = new List<int>();
                        personAndGrades[personName].AddRange(personAndGrades[toAddToTheDict[1]]);
                    }
                }
                
                inputPersonAndGrades = Console.ReadLine();
            }

            foreach (var kvp in personAndGrades)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ", kvp.Value)}");
            }
        }
    }
}