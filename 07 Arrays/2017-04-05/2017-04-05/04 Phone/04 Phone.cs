using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] telNos = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);   // !!
            string[] nameZ = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);    // !!
            int[] digits = new int[telNos.Length];
            int[] diffs = new int[telNos.Length];

            for (int i = 0; i < telNos.Length; i++)
            {
                int sum = 0;
                int diffff = 0;
                string currentNumber = telNos[i];
                for (int j = 0; j < currentNumber.Length; j++)                                                         // !!
                {
                    if (currentNumber[j] >= 48 && currentNumber[j] <= 57)
                    {
                        sum += int.Parse(currentNumber[j].ToString());
                        diffff -= int.Parse(currentNumber[j].ToString());
                    }
                }
                digits[i] = sum;
                diffs[i] = diffff;
            }

            while (true)
            {
                string[] read = Console.ReadLine().Split(' ');
                if (read[0] == "done")
                {
                    break;
                }
                else if (read[0] == "call")
                {
                    for (int i = 0; i < nameZ.Length; i++)
                    {
                        if (read[1] == nameZ[i])
                        {
                            Console.WriteLine("calling {0}...", telNos[i]);
                            if (digits[i] % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else if (digits[i] % 2 == 0)
                            {
                                string HH = digits[i] / 60 <= 9 ? "0" + (digits[i] / 60).ToString() : (digits[i] / 60).ToString();  // !!
                                string MM = digits[i] % 60 <= 9 ? "0" + (digits[i] % 60).ToString() : (digits[i] % 60).ToString();
                                Console.WriteLine($"call ended. duration: {HH}:{MM}");
                            } 
                        }
                        else if (read[1] == telNos[i])
                        {
                            Console.WriteLine("calling {0}...", nameZ[i]);
                            if (digits[i] % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else if (digits[i] % 2 == 0)
                            {
                                string HH = digits[i] / 60 <= 9 ? "0" + (digits[i] / 60).ToString() : (digits[i] / 60).ToString();
                                string MM = digits[i] % 60 <= 9 ? "0" + (digits[i] % 60).ToString() : (digits[i] % 60).ToString();                              
                                Console.WriteLine($"call ended. duration: {HH}:{MM}");                               
                            }
                        }
                    }
                }
                else if (read[0] == "message")
                {
                    for (int i = 0; i < nameZ.Length; i++)
                    {
                        if (read[1] == nameZ[i])
                        {
                            Console.WriteLine("sending sms to {0}...", telNos[i]);
                            if (diffs[i] % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else if (diffs[i] % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                        else if (read[1] == telNos[i])
                        {
                            Console.WriteLine("sending sms to {0}...", nameZ[i]);
                            if (diffs[i] % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else if (diffs[i] % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                    }
                }
            }
        }
    }
}