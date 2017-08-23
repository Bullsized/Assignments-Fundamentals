using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 out of 100

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> answer = new Dictionary<string, decimal> {
                { "Technical", 0},
                { "Theoretical", 0},
                { "Practical", 0}
            };

            for (int i = 0; i < n; i++)
            {
                decimal distance = decimal.Parse(Console.ReadLine());

                decimal cargo = decimal.Parse(Console.ReadLine());

                string team = Console.ReadLine();

                decimal result = (((cargo * 1000m) * 1.5m) - (0.7m * 2.5m * (distance * 1600m)));

                answer[team] += result;
            }

            decimal money = answer.Values.Max();

            string winner = string.Empty;

            foreach (var kvp in answer)
            {
                if (money == kvp.Value)
                {
                    winner = kvp.Key;
                    break;
                }
            }

            Console.WriteLine($"The {winner} Trainers win with ${money:f3}.");
        }
    }
}