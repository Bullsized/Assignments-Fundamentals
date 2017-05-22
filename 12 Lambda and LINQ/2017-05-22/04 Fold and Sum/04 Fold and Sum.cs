using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int dividedByFour = givenList.Count / 4;

            List<int> topRowLeft = givenList
                .Take(dividedByFour)
                .Reverse()
                .ToList();

            List<int> topRowRight = givenList
               .Skip(dividedByFour * 3)
               .Reverse()
               .Take(dividedByFour)
               .ToList();

            List<int> topRowFull = topRowLeft
                .Concat(topRowRight)
                .ToList();

            List<int> bottomRowFull = givenList
                .Skip(dividedByFour)
                .Take(dividedByFour * 2)
                .ToList();

            for (int cycle = 0; cycle < topRowFull.Count; cycle++)
            {
                bottomRowFull[cycle] += topRowFull[cycle];
            }

            Console.WriteLine(string.Join(" ", bottomRowFull));

        }
    }
}