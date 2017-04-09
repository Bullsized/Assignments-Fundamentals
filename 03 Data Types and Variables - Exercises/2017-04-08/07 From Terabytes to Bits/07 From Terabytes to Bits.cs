using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal terabytes = decimal.Parse(Console.ReadLine());
            decimal bytes = terabytes * (decimal)Math.Pow(1024, 4) * 8;

            Console.WriteLine("{0:f0}", bytes);
        }
    }
}