using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                if (i == number - 1)
                {
                    string parseThis = Console.ReadLine();
                    result += parseThis;
                }
                else
                {
                string parseThis = Console.ReadLine();
                result += parseThis;
                result += delimiter;
                }
            }

            Console.WriteLine(result);

            //{
            //string[] sentence = new string[number];
            //  for (int i = 0; i < number; i++)
            //    sentence[i] = Console.ReadLine();
            //}
            //for (int m = 0; m < number; m++)
            //{
            //    if (m == sentence.Length-1)
            //    {
            //        Console.Write(sentence[sentence.Length-1]);
            //    }
            //    else
            //    {
            //    Console.Write(sentence[m] + delimiter);
            //    }
            //}
            //Console.WriteLine();
        }
    }
}