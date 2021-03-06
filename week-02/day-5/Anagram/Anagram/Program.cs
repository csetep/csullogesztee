﻿using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            bool solution = true;
            Console.WriteLine("Add a word!");
            string word1 = Console.ReadLine();

            Console.WriteLine("Add a word!");
            string word2 = Console.ReadLine();

            if (word1.Length == word2.Length)
            {
                char[] word1arr = word1.ToCharArray();
                char[] word2arr = word2.ToCharArray();
                Array.Sort(word1arr);
                Array.Sort(word2arr);
                foreach (char letter1 in word1arr)
                {
                    foreach (char letter2 in word2arr)
                    {
                        if (letter1 == letter2)
                        {
                            solution = true;
                        }
                        else
                        {
                            solution = false;
                        }
                    }
                }
            }
            else
            {
                solution = false;
            }

            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}
