using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Cypher_Roulette_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //bool spinRight = true;
            bool spinLeft = true;
            string currString = string.Empty;
            string prevString = string.Empty;
            string finalString = string.Empty;
            string nowString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                currString = Console.ReadLine();
                nowString = currString;

                if (currString == "spin")
                {
                    if (spinLeft)
                    {
                        spinLeft = false;
                        //spinRight = true;
                    }
                    else
                    {
                        spinLeft = true;
                        //spinRight = false;
                    }
                    i--;
                    nowString = string.Empty;
                }

                if (prevString == currString)
                {
                    if (currString == "spin")
                    {
                        if (spinLeft)
                        {
                            spinLeft = false;
                            //spinRight = true;
                        }
                        else
                        {
                            spinLeft = true;
                            //spinRight = false;
                        }
                    }
                    finalString = string.Empty;
                    continue;
                }

                if (spinLeft)
                {
                    finalString = finalString + nowString;
                }
                else
                {
                    finalString = nowString + finalString;
                }
                prevString = currString;
            }
            Console.WriteLine(finalString);
        }
    }
}
