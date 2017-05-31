using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Registered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> registeredUsernames = new Dictionary<string, DateTime>();

            string inputLine = Console.ReadLine();

            //  .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
            //  .ToList();
            while (inputLine != "end")
            {
                string[] inputParams = inputLine
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string username = inputParams[0];
                DateTime registryDate = DateTime.Parse(inputParams[1]);

                registeredUsernames.Add(username, registryDate);

                inputLine = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsernames =
                registeredUsernames
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedUsernames)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}