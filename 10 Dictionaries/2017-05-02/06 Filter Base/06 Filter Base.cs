using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> employeeAge = new Dictionary<string, int>();
            Dictionary<string, decimal> employeeSalary = new Dictionary<string, decimal>();
            Dictionary<string, string> employeePosition = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "filter base")
            {
                var splittedString = input.Split(' ').ToArray();

                int testerInt = 0;
                decimal testerDec = 0M;

                if (int.TryParse(splittedString[2], out testerInt))
                {
                    employeeAge[splittedString[0]] = testerInt;
                }
                else if (decimal.TryParse(splittedString[2], out testerDec))
                {
                    employeeSalary[splittedString[0]] = testerDec;
                }
                else
                {
                    employeePosition[splittedString[0]] = splittedString[2];
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (var kvc in employeeAge)
                {
                    Console.WriteLine("Name: {0}", kvc.Key);
                    Console.WriteLine("Age: {0}", kvc.Value);
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Salary")
            {
                foreach (var kvc in employeeSalary)
                {
                    Console.WriteLine("Name: {0}", kvc.Key);
                    Console.WriteLine("Salary: {0:f2}", kvc.Value);
                    Console.WriteLine("====================");
                }
            }
            if (input == "Position")
            {
                foreach (var kvc in employeePosition)
                {
                    Console.WriteLine("Name: {0}", kvc.Key);
                    Console.WriteLine("Position: {0}", kvc.Value);
                    Console.WriteLine("====================");
                }
            }

        }
    }
}