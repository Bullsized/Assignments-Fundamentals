using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            // playing with the algorithm 50/100

            List<int> cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> participants = Console.ReadLine().Split(' ').ToList();
            bool luckyGuys = true;

            for (int turnOfDeath = 0; turnOfDeath < participants.Count; turnOfDeath++)
            {
                string[] player = participants[turnOfDeath].Split(',').ToArray();

                int rotatingValue = int.Parse(player[0]);
                string direction = player[1];

                if (direction == "Left")
                {
                    if (rotatingValue > 6)
                    {
                        if (cylinder[6 - (rotatingValue % 6)] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", turnOfDeath);
                            luckyGuys = false;
                            break;
                        }
                    }
                    else if (rotatingValue <= 6)
                    {
                        if (cylinder[6 - rotatingValue] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", turnOfDeath);
                            luckyGuys = false;
                            break;
                        }
                    }
                    else
                    {
                        ShiftingTheCylinder(cylinder);
                    }
                }
                else if (direction == "Right")
                {
                    if (rotatingValue > 6)
                    {
                        if (cylinder[rotatingValue % 6] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", turnOfDeath);
                            luckyGuys = false;
                            break;
                        }
                    }
                    else if (rotatingValue <= 6)
                    {
                        if (cylinder[rotatingValue - 1] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", turnOfDeath);
                            luckyGuys = false;
                            break;
                        }
                    }
                    else
                    {
                        ShiftingTheCylinder(cylinder);
                    }
                }

            }
            if (luckyGuys)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        static void ShiftingTheCylinder(List<int> cylinder)
        {
            if (cylinder[cylinder.Count - 1] == 1)
            {
                cylinder[0] = 1;
                cylinder[cylinder.Count - 1] = 0;
            }
            else
            {
                cylinder.Insert(0, 0);
                cylinder.RemoveAt(cylinder.Count - 1);
            }
        }
    }
}