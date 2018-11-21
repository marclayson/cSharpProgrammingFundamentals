using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                           .Split(' ')
                           .Select(double.Parse)
                           .ToArray();


            Console.WriteLine($"{string.Join(" ", nums.OrderByDescending(x => x).Take(3))}");
        }
    }
}
