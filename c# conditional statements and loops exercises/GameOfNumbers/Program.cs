using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchCounter = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int combination = 0;
            int sumcom = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = m; i >= n; i--)
            {
                for (int k = m; k >= n; k--)
                {
                    sum = k + i;
                    combination++;
                    if (sumcom==sum)
                    {
                        Console.WriteLine($"Number found! {i} + {k} = {sumcom}");
                        matchCounter++;
                        return;
                    }
                }
            }
            if (matchCounter == 0)
            {
                Console.WriteLine($"{combination} combinations - neither equals {sumcom}");
            }

        }
    }
}
