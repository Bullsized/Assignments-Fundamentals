using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SWSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textRead = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '?', '!', '/', '\\', '\'', '.', ',', ':', ';', '(', ')', '[', ']', '"', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> editedTextRead = textRead
                .Distinct()
                .OrderBy(l => l)
                .Where(w => w.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ", editedTextRead));
        }
    }
}