using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Squared_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answer = new List<int>();
            foreach (int digit in numbers)
            {
                var checkIfSquared = Math.Sqrt(digit);
                if (checkIfSquared == (int)checkIfSquared)
                {
                    answer.Add(digit);
                }
            }
            answer.Sort();
            answer.Reverse();

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}