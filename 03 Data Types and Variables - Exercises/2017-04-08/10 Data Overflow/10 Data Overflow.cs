using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong digitOne = ulong.Parse(Console.ReadLine());
            ulong digitTwo = ulong.Parse(Console.ReadLine());
            bool smallerByte = false;
            bool smallerUshort = false;
            bool smallerUint = false;
            bool smallerUlong = false;
            bool biggerByte = false;
            bool biggerUshort = false;
            bool biggerUint = false;
            bool biggerUlong = false;
            if (digitOne < digitTwo)
            {
                if (digitOne <= byte.MaxValue) smallerByte = true;
                else if (digitOne <= ushort.MaxValue) smallerUshort = true;
                else if (digitOne <= uint.MaxValue) smallerUshort = true;
                else if (digitOne <= ulong.MaxValue) smallerUlong = true;

                if (digitTwo <= byte.MaxValue) biggerByte = true;
                else if (digitTwo <= ushort.MaxValue) biggerUshort = true;
                else if (digitTwo <= uint.MaxValue) biggerUint = true;
                else if (digitTwo <= ulong.MaxValue) biggerUlong = true;

                if (biggerUshort && smallerByte)
                {
                    Console.WriteLine("bigger type: ushort\nsmaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", digitTwo, Math.Round(((decimal)digitTwo / (decimal)byte.MaxValue)));
                }
                if (biggerUint && smallerByte)
                {
                    Console.WriteLine("bigger type: uint\nsmaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", digitTwo, Math.Round(((decimal)digitTwo / (decimal)byte.MaxValue)));
                }
                if (biggerUlong && smallerByte)
                {
                    Console.WriteLine("bigger type: ulong\nsmaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", digitTwo, Math.Round(((decimal)digitTwo / (decimal)byte.MaxValue)));
                }
                if (biggerUint && smallerUshort)
                {
                    Console.WriteLine("bigger type: uint\nsmaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", digitTwo, Math.Round((decimal)digitTwo / (decimal)ushort.MaxValue));
                }
                if (biggerUlong && smallerUshort)
                {
                    Console.WriteLine("bigger type: ulong\nsmaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", digitTwo, Math.Round((decimal)digitTwo / (decimal)ushort.MaxValue));
                }
                if (biggerUlong && smallerUint)
                {
                    Console.WriteLine("bigger type: ulong\nsmaller type: uint");
                    Console.WriteLine("{0} can overflow uint {1} times", digitTwo, Math.Round((decimal)digitTwo / (decimal)uint.MaxValue));
                }

            }
            else if (digitOne > digitTwo)
            {
                if (digitTwo <= byte.MaxValue) smallerByte = true;
                else if (digitTwo <= ushort.MaxValue) smallerUshort = true;
                else if (digitTwo <= uint.MaxValue) smallerUint = true;
                else if (digitTwo <= ulong.MaxValue) smallerUlong = true;

                if (digitOne <= byte.MaxValue) biggerByte = true;
                else if (digitOne <= ushort.MaxValue) biggerUshort = true;
                else if (digitOne <= uint.MaxValue) biggerUint = true;
                else if (digitOne <= ulong.MaxValue) biggerUlong = true;

                if (biggerUshort && smallerByte)
                {
                    Console.WriteLine("bigger type: ushort\nsmaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", digitOne, Math.Round((decimal)digitOne / (decimal)byte.MaxValue));
                }
                if (biggerUint && smallerByte)
                {
                    Console.WriteLine("bigger type: uint\nsmaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", digitOne, Math.Round((decimal)digitOne / (decimal)byte.MaxValue));
                }
                if (biggerUlong && smallerByte)
                {
                    Console.WriteLine("bigger type: ulong\nsmaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", digitOne, Math.Round((decimal)digitOne / (decimal)byte.MaxValue));
                }
                if (biggerUint && smallerUshort)
                {
                    Console.WriteLine("bigger type: uint\nsmaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", digitOne, Math.Round((decimal)digitOne / (decimal)ushort.MaxValue));
                }
                if (biggerUlong && smallerUshort)
                {
                    Console.WriteLine("bigger type: ulong\nsmaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", digitOne, Math.Round((decimal)digitOne / (decimal)ushort.MaxValue));
                }
                if (biggerUlong && smallerUint)
                {
                    Console.WriteLine("bigger type: ulong\nsmaller type: uint");
                    Console.WriteLine("{0} can overflow uint {1} times", digitOne, Math.Round((decimal)digitOne / (decimal)uint.MaxValue));
                }
            }
        }
    }
}