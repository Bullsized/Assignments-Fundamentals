using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //-100
            //128
            //-3540
            //64876
            // 2147483648
            //-1141583228
            //-1223372036854775808

            sbyte firstNu = -100;
            byte secondNu = 128;
            short thirdNu = -3540;
            ushort fourthNu = 64876;
            uint fifthNu = 2147483648;
            int sixthNu = -1141583228;
            long seventhNu = -1223372036854775808;

            Console.WriteLine($"{firstNu}\n{secondNu}\n{thirdNu}\n{fourthNu}\n{fifthNu}\n{sixthNu}\n{seventhNu}");

        }
    }
}