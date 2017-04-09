using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int digitTwo = int.Parse(Console.ReadLine());

            if (sign == "+")  Console.WriteLine("{0} + {1} = {2}", digitOne, digitTwo, digitOne + digitTwo); 
            else if (sign == "-") Console.WriteLine("{0} - {1} = {2}", digitOne, digitTwo, digitOne - digitTwo); 
            else if (sign == "*") Console.WriteLine("{0} * {1} = {2}", digitOne, digitTwo, digitOne * digitTwo); 
            else if (sign == "/") Console.WriteLine("{0} / {1} = {2}", digitOne, digitTwo, digitOne / digitTwo); 
        }
    }
}