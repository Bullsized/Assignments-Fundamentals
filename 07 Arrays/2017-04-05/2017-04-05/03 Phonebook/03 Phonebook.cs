using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] telNos = Console.ReadLine().Split(' ').ToArray();
            string[] nameZ = Console.ReadLine().Split(' ').ToArray();
            

            for (int i = 0; i < int.MaxValue; i++)
            {
                string read = Console.ReadLine();

                for (int x = 0; x < nameZ.Length; x++)
                {
                    if (read == nameZ[x])
                    {
                        Console.WriteLine($"{nameZ[x]} -> {telNos[x]}");
                    }

                }

                if (read == "done")
                {
                    break;
                }
            }
        }
    }
}