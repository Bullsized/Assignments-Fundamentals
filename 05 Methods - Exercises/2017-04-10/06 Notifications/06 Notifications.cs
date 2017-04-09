using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = n * 3;

            while (count != 0)
            {                
                string successOrError = Console.ReadLine();
                if (successOrError == "success")
                {
                    count -= 3;
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (successOrError == "error")
                {
                    count -= 3;
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
                else
                {
                    count -= 3;
                }
            }

        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code > 0)
            {
                Console.WriteLine($"Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine($"Reason: Internal System Failure.");
            }
        }
    }
}