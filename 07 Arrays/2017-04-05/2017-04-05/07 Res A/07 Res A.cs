using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Res_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] massive = new int?[4];

            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
                
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {

                    break;
                }
                else if (command == "clear")
                {
                    for (int cyc = 0; cyc < massive.Length; cyc++)
                    {
                   
                    }
                }
                else
                {

                }

            }

        }
    }
}
