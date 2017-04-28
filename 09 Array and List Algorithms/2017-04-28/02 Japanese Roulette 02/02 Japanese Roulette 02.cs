using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Japanese_Roulette_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cylinder = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> players = Console.ReadLine()
                .Split()
                .ToList();

            int currentMuzzlePosition = 2;

            int bulletPosition = 0;
            bulletPosition = BulletPosition(cylinder, bulletPosition);

            for (int i = 0; i < players.Count; i++)
            {
                string[] playerInfo = players[i].Split(',');

                int player = i;

                int strength = int.Parse(playerInfo[0]);

                string position = playerInfo[1];

                currentMuzzlePosition = MuzzlePosition(currentMuzzlePosition, strength, position);

                if (bulletPosition == currentMuzzlePosition)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }

                if (bulletPosition < 6)
                {
                    bulletPosition++;
                }
                else
                {
                    bulletPosition = 0;
                }
            }

            Console.WriteLine("Everybody got lucky!");

        }

        public static int MuzzlePosition(int muzzle, int strength, string position)
        {
            switch (position)
            {
                case "Left":
                    muzzle = (muzzle + strength) % 6;
                    break;

                case "Right":
                    muzzle = 6 - Math.Abs(muzzle - strength) % 6;
                    break;
            }

            return muzzle;
        }

        public static int BulletPosition(List<int> cylinder, int bulletPosition)
        {
            for (int i = 0; i < cylinder.Count; i++)
            {
                if (cylinder[i] == 1)
                {
                    bulletPosition = i;
                    break;
                }
            }

            return bulletPosition;
        }
    }
}
