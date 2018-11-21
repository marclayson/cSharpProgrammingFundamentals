﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var banword in banWords)
            {
                if (text.Contains(banword))
                {
                    text = text.Replace(banword, new string ('*', banword.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
