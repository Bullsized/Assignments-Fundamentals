using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();

            string wordForLists = string.Empty;

            for (int cycle1 = 0; cycle1 < words.Count; cycle1++)
            {
                string currentWord = words[cycle1];
                bool isUpperCase = UpperCase(currentWord);             
                bool isLowerCase = LowerCase(currentWord);

                if (isUpperCase)
                {
                    upper.Add(currentWord);
                }
                else if (isLowerCase)
                {
                    lower.Add(currentWord);
                }
                else
                {
                    mixed.Add(currentWord);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }

        static bool UpperCase(string upper)
        {          
            foreach (char letter in upper)
            {
                if (letter <= 'A' && letter >= 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        static bool LowerCase(string lower)
        {
            foreach (char letter in lower)
            {
                if (letter <= 'a' && letter >= 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}