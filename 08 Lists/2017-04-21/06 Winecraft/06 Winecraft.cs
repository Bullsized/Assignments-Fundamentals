using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapeList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());

            while (grapeList.Count > growthDays)
            {
                for (int rows = 0; rows < growthDays; rows++)
                {
                    for (int columns = 0; columns < grapeList.Count; columns++)
                    {
                        if (grapeList[columns] <= 0)
                        {
                            grapeList.RemoveAt(columns);
                            columns--;
                        }
                        else if (1 <= columns && columns <= grapeList.Count - 2
                            && grapeList[columns] > grapeList[columns - 1]
                            && grapeList[columns] > grapeList[columns + 1])
                        {
                            grapeList[columns] += 2;
                            grapeList[columns - 1] -= 2;
                            grapeList[columns + 1] -= 1;
                            columns++;
                        }
                        else
                        {
                            grapeList[columns]++;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", grapeList));
        }
    }
}