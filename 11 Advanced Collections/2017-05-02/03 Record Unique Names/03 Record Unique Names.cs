using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopper = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int cycle = 0; cycle < stopper; cycle++)
            {
                string givenName = Console.ReadLine();
                names.Add(givenName);
            }

            foreach (var nameToBePrinted in names)
            {
                Console.WriteLine(nameToBePrinted);
            }
        }
    }
}