using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                           .Split(' ')
                           .Select(int.Parse)
                           .ToArray();
            int k = nums.Length / 4;

            int[] leftsideR1 = nums.Take(k).Reverse().ToArray();
            int[] rightSideR2 = nums.Reverse().Take(k).ToArray();
            int[] row1 = leftsideR1.Concat(rightSideR2).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
