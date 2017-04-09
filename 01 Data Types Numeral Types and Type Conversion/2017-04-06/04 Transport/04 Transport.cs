using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ppl = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(ppl / 24));
        }
    }
}