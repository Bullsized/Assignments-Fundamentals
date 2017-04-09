using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal proximaCent = 4.22M * 9450000000000M;
            decimal milkyWay = 26000M * 9450000000000M;
            decimal milkyWayDiam = 100000M * 9450000000000M;
            decimal earth = 46500000000M * 9450000000000M;

            Console.WriteLine($"{proximaCent:E2}\n{milkyWay:E2}\n{milkyWayDiam:E2}\n{earth:E2}");

        }
    }
}