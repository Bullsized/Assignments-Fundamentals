using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flowers = Console.ReadLine().Split(null).Select(int.Parse).ToArray();
            string result = flowerDays(flowers);
            Console.WriteLine(result);
        }

        static string flowerDays(int[] flowers)
        {
            int daysCompleted = 0;
            int seasons = 0;

            while (flowers.Max() != 0)
            {
                for (int days = 0; days < flowers.Length; days++)
                {
                    for (int individual = 0; individual < flowers.Length; individual++)
                    {
                        if (days != individual && flowers[individual] > 0)
                        {
                            flowers[individual]--;
                        }
                    }

                    daysCompleted++;
                    if (flowers.Max() == 0)
                    { 
                        return $"survived {daysCompleted} days ({seasons} seasons)";
                    }
                }               

                for (int endOfSeason = 0; endOfSeason < flowers.Length; endOfSeason++)
                {
                    if (flowers[endOfSeason] > 0)
                    {
                        flowers[endOfSeason]++;
                    }
                }

                seasons++;
            }

            return $"survived {daysCompleted} days ({seasons} seasons)";
        }
    }
}
