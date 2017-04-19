using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstMassive = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] secondMassive = Console.ReadLine().Split(' ').ToArray();

            int xAxis = 0; //-x left   +x right
            int yAxis = 0; //-y down   +y up

            for (int i = 0; i < secondMassive.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (secondMassive[i] == "left")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);
                        xAxis -= addition;
                    }
                    else if (secondMassive[i] == "right")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);
                        xAxis += addition;
                    }
                    else if (secondMassive[i] == "up")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);
                        yAxis += addition;
                    }
                    else if (secondMassive[i] == "down")
                    {
                        int addition = int.Parse(secondMassive[i + 1]);
                        yAxis -= addition;
                    }
                }
            }

            if (xAxis == firstMassive[0] && yAxis == firstMassive[1])
            {
                Console.WriteLine("firing at [{0}, {1}]", xAxis, yAxis);
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("firing at [{0}, {1}]", xAxis, yAxis);
                Console.WriteLine("better luck next time...");
            }
        }
    }
}