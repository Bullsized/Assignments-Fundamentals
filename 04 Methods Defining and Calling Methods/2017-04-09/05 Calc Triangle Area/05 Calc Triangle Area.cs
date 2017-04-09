using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Calc_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Solution(width, height));
        }
        /// <summary>
        /// Solition trqbwa da e decimal ( nqkakva promenliva ) v methoda, inache shte izkara greshka
        /// osven tova samo togava dava return, inache s void gurmi pak
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static decimal Solution(decimal width, decimal height)
        {
            return (width * height) / 2;
        }
    }
}