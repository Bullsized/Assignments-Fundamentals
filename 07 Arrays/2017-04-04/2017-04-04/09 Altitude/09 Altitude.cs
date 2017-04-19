using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massive = Console.ReadLine().Split(' ');
            decimal sum = decimal.Parse(massive[0]);
            bool lamp = false;

            for (int i = 0; i < massive.Length; i++)
            {
                if (i % 2 != 0) // 1 3 5 7 demek 4islata  plius minus n
                {
                    if (massive[i] == "up")
                    {
                        sum += decimal.Parse(massive[i + 1]);
                    }
                    else if (massive[i] == "down")
                    {
                        sum -= decimal.Parse(massive[i + 1]);
                    }

                    if (sum <= 0)
                    {
                        lamp = true;
                        break;
                    }
                }
            }
            if (lamp == true)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", sum);
            }
        }
    }
}