using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Travelling_at_Light_Speed_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ly = double.Parse(Console.ReadLine());

            double timeToConvert = 9450000000000 / 300000 * ly;

            TimeSpan time = TimeSpan.FromSeconds(timeToConvert);

            double weeks = time.Days / 7;
            double days = time.Days % 7;
            double hours = time.Hours;
            double minutes = time.Minutes;
            double seconds = time.Seconds;

            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}