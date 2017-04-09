using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Variable_in_Hexa_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();
            int decValue = Convert.ToInt32(hexValue, 16);
            Console.WriteLine(decValue);
        }
    }
}