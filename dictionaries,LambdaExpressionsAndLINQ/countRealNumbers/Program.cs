using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var count = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }

                
            }
            foreach (var num in count.Keys)
            {
                Console.WriteLine($"{num} -> {count[num]}");
            }
         
        }
    }
}
