using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripleOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyLetters = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 <  howManyLetters; i1++)
            {
                for (int i2 = 0; i2 < howManyLetters; i2++)
                {
                    for (int i3 = 0; i3 <howManyLetters; i3++)
                    {
                        char letter1 = (char)('a' + i1);
                        char letter2 = (char)('a' + i2);
                        char letter3 = (char)('a' + i3);
                        Console.Write(letter1);
                        Console.Write(letter2);
                        Console.WriteLine(letter3);
                    }
                }
            }
        }
    }
}
