using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flowerz = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // 1 2 3 4 
            int season = 0;
            int dni = 0;

            while (flowerz[flowerz.Length - 1] != 0)
            {
                for (int days = 0; days < flowerz.Length; days++)
                {
                    dni++;
                    for (int indexes = 0; indexes < flowerz.Length; indexes++)
                    {
                        if (flowerz[flowerz.Length - 1] == 0)
                        {
                            break;
                        }

                        if (indexes == days && flowerz[indexes] - 1 != 0)
                        {
                            flowerz[indexes]++;
                        }
                        else if (indexes == days && flowerz[indexes] - 1 == 0)
                        {
                            flowerz[indexes] = 1;
                        }
                        else if (indexes != days && flowerz[indexes] - 1 != 0 && flowerz[indexes] != 0)
                        {
                            flowerz[indexes] -= 1;
                        }
                        else if (flowerz[indexes] - 1 == 0)
                        {
                            flowerz[indexes] = 0;
                        }
                    }
                    if (flowerz[flowerz.Length - 1] == 0)
                    {
                        break;
                    }
                }
                season++;
            }
            if (season - 1 == 1)
            {
                Console.WriteLine("survived {0} days ({1} season)", dni - 1, season - 1);
            }
            else
            {
                Console.WriteLine("survived {0} days ({1} seasons)", dni - 1, season - 1);
            }
        }
    }
}