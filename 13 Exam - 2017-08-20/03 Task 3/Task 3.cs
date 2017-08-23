using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 out of 100

            string pattern = @"^(<\[[^a-zA-Z0-9]*\]\.){1}(\.\[[a-zA-Z0-9]*\]\.)*$";

            Regex regex = new Regex(pattern);

            string inputLine = Console.ReadLine();

            while (inputLine != "Traincode!")
            {
                Match train = regex.Match(inputLine);

                if (train.Success)
                {
                    Console.WriteLine(train.Value.ToString());
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}