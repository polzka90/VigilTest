using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private const string text = @"In 1991, while studying computer science at University of Helsinki, Linus Torvalds began a project that later became the Linux kernel. He wrote the program specifically for the hardware he was using and independent of an operating system because he wanted to use the functions of his new PC with an 80386 processor. Development was done on MINIX using the GNU C Compiler.";
        private const int limit = 40;
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string[] words = new string[text.Split(' ').Length];

            words = text.Split(' ');

            string line = string.Empty;

            foreach(string word in words)
            {
                if ((line + " " + word).Length > limit)
                {
                    lines.Add(line);
                    line = word;
                }
                else
                    line += line == string.Empty ? word : (" " + word);
            }
            lines.Add(line);

            Console.WriteLine(string.Join("\n", lines));
        }
    }
}
