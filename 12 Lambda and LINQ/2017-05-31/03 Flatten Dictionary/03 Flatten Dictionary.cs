using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var solution = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                List<string> dividedStrings = input.Split(' ').ToList();
                string seeIfStringExists = dividedStrings[0];

                if (true)
                {

                }

                string copyFirstString = seeIfStringExists;
                input = Console.ReadLine();
            }
        }
    }
}