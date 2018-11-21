using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string patttern = Console.ReadLine().ToLower();
            int count = 0;
            int index = input.IndexOf(patttern);
            while (index != -1)
            {
                count++;
                index = input.IndexOf(patttern, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
