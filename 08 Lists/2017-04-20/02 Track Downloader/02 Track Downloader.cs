﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> containsSymbols = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<string> answer = new List<string>();

            string songs = Console.ReadLine();

            while (songs != "end")
            {
                for (int cycle = 0; cycle < containsSymbols.Count; cycle++)
                {
                    if (songs.Contains(containsSymbols[cycle]))
                    {
                         break;
                    }
                    else if (cycle == containsSymbols.Count - 1)
                    {
                        answer.Add(songs);                        
                    }
                }
                songs = Console.ReadLine();
            }

            answer.Sort();

            foreach (string title in answer)
            {
                Console.WriteLine(title);
            }
        }
    }
}