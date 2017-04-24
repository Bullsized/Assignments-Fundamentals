using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int cycleMargin = int.Parse(Console.ReadLine());

            for (int cycle = 0; cycle < cycleMargin; cycle++)
            {
                List<int> secondaryList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                CheckDigitsInLists(primalList, secondaryList);
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }

        static List<int> CheckDigitsInLists(List<int> primal, List<int> secondary)
        {
            for (int secCycle = 0; secCycle < secondary.Count; secCycle++)
            {
                bool lamp = false;
                for (int priCycle = 0; priCycle < primal.Count; priCycle++)
                {
                    if (secondary[secCycle] == primal[priCycle])
                    {
                        primal.RemoveAt(priCycle);
                        priCycle--;
                        lamp = true;
                    }
                    else if (priCycle == primal.Count - 1 && lamp == false)
                    {
                        primal.Add(secondary[secCycle]);
                        break;
                    }
                }
            }
            return primal;
        }
    }
}