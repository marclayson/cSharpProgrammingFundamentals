using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int com = 0;

            for (int i = n; i >=1 ; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                   
                    totalSum += (i * k) * 3;
                    com++;
                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{com} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                    }
                }
                
            }
            Console.WriteLine($"{com} combinations");
            Console.WriteLine($"Sum: {totalSum}");
            
        }
    }
}
