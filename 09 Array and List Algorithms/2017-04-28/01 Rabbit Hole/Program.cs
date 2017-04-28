using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {

            // 60 out of 100, just playing with the algorhithm of the task ~


            List<string> commands = Console.ReadLine().Split(new char[] { ' ', '|' }).ToList();
            int health = int.Parse(Console.ReadLine());

            for (int cycle = 0; cycle < commands.Count - 1; cycle++)
            {
                if (commands[cycle] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    string direction = commands[cycle];
                    int damage = int.Parse(commands[cycle + 1]);

                    if (direction == "Left")
                    {
                        health -= damage;
                        int currentDigitCicle = (cycle - 1) / 2;
                        int realCounterForTotalCommands = (commands.Count - 1) / 2;
                        for (int i = currentDigitCicle; i < realCounterForTotalCommands; i--)
                        {
                            damage--;
                            if (damage == 0)
                            {
                                break;
                            }
                            if (i == 0)
                            {
                                i = realCounterForTotalCommands - 1;
                            }
                        }
                        cycle = (currentDigitCicle * 2) + 1;
                    }

                    else if (direction == "Right")
                    {
                        health -= damage;
                        int currentDigitCicle = (cycle - 1) / 2;
                        int realCounterForTotalCommands = (commands.Count - 1) / 2;
                        for (int i = currentDigitCicle; i < realCounterForTotalCommands; i++)
                        {
                            damage--;
                            if (damage == 0)
                            {
                                break;
                            }
                            if (i == realCounterForTotalCommands - 1)
                            {
                                i = 0;
                            }
                        }
                        cycle = (currentDigitCicle * 2) + 1;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }

                    if (direction == "Bomb")
                    {
                        health -= damage;
                        commands.RemoveAt(cycle);
                        commands.RemoveAt(cycle);
                        cycle = 0;
                        if (health <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            break;
                        }
                    }
                    //else
                    //{
                    //    if (commands[commands.Count] != "RabbitHole")
                    //    {
                    //        commands.RemoveAt(commands.Count);
                    //        commands.RemoveAt(commands.Count - 1);
                    //        commands.Add("Bomb");
                    //        commands.Add(string.Empty + health);
                    //    }
                    //    else
                    //    {
                    //        commands.Add("Bomb");
                    //        commands.Add(string.Empty + health);
                    //    }
                    }
                }
            }
        }
    }
}