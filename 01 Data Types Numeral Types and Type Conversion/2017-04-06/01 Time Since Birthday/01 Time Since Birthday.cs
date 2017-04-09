using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Time_Since_Birthday
{
    class Program
    {
        static void Main(string[] args)
        { //Write program to enter an integer number of years and convert it to days, hours and minutes.
            //20 years = 7300 days = 175200 hours = 10512000 minutes.
            byte years = byte.Parse(Console.ReadLine());

            ushort days = (ushort)(years * 365);
            int hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}