using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exact_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal product = 1;

            for (int cycle1 = 0; cycle1 < n; cycle1++)
            {
                decimal nuevo = decimal.Parse(Console.ReadLine());
                product *= nuevo;
            }
            Console.WriteLine(product);
        }
    }
}