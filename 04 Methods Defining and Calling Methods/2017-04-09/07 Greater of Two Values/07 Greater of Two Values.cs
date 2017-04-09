using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int": IntCase(); break;
                case "char": CharCase(); break;
                case "string": StringCase(); break;
                default: break;
            }
        }

        static void IntCase()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int result = Math.Max(first, second);
            Console.WriteLine(result);
            //if (first >= second)
            //{
            //    Console.WriteLine(first);
            //}
            //else
            //{
            //    Console.WriteLine(second);
            //}
        }

        static void CharCase()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            if (first >= second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void StringCase()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.CompareTo(second) >= 0)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
            //int sumFirst = 0;
            //int sumSecond = 0;
            //foreach (char letter in first)
            //{
            //    sumFirst++;
            //}
            //foreach (char letter in second)
            //{
            //    sumSecond++;
            //}
            //if (sumFirst >= sumSecond)
            //{
            //    Console.WriteLine(first);
            //}
            //else
            //{
            //    Console.WriteLine(second);
            //}
        }
    }
}