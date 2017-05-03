using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGrades = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> solution = new Dictionary<string, List<double>>();
           
            for (int cycle = 0; cycle < totalGrades; cycle++)
            {
                string[] nameAndGrade = Console.ReadLine().Split().ToArray();

                if (!solution.ContainsKey(nameAndGrade[0]))
                {
                    solution[nameAndGrade[0]] = new List <double>();
                    solution[nameAndGrade[0]].Add(double.Parse(nameAndGrade[1]));
                }
                else
                {
                    solution[nameAndGrade[0]].Add(double.Parse(nameAndGrade[1]));
                }
            }

            //much easier method to print everything, yet the system is only giving me 50/100:
            //foreach (var kvp in solution)
            //{
            //    Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value)} (avg: {kvp.Value.Average():f2})");
            //}

            //solution for 100/100: 
            foreach (var kvp in solution)
            {
                var student = kvp.Key;
                var grades = kvp.Value;

                Console.Write($"{student} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {grades.Average():f2})");
            }
        }
    }
}