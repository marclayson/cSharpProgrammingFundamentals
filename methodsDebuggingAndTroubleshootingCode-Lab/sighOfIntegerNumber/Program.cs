using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sighOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSigh(n);
        }

        static void PrintSigh(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The Number {number} is negative.");
            }
            else if (number == 0 )
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
