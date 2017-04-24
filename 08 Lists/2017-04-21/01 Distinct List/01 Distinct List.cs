using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int rowCycle = 0; rowCycle < inputIntegers.Count; rowCycle++)
            {
                for (int digitCycle = 1 + rowCycle; digitCycle < inputIntegers.Count; digitCycle++)
                {
                    if (inputIntegers[rowCycle] == inputIntegers[digitCycle])
                    {
                        inputIntegers.RemoveAt(digitCycle);
                        digitCycle--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", inputIntegers));
        }
    }
}