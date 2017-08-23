using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 out of 100

            int locoPower = int.Parse(Console.ReadLine());

            string theFollowUp = Console.ReadLine();

            List<int> wagonTrain = new List<int>();

            while (theFollowUp != "All ofboard!")
            {
                int wagon = int.Parse(theFollowUp);

                wagonTrain.Add(wagon);

                if (wagonTrain.Sum() > locoPower)
                {
                    var nearest = wagonTrain.OrderBy(x => Math.Abs(x - wagonTrain.Average())).First();
                    wagonTrain.Remove(nearest);
                }

                theFollowUp = Console.ReadLine();
            }

            wagonTrain.Reverse();

            Console.WriteLine(string.Join(" ", wagonTrain) + " " + locoPower);
        }
    }
}
