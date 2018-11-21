using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalMoneyLoss = 0m;
            BigInteger securityToken = 1;
            for (int i = 0; i <n; i++)
            {
                securityToken *= securityKey;
            }
            
            

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string siteName = data[0];
                long siteVisits = long.Parse(data[1]);
                decimal sitePricePerVisit = decimal.Parse(data[2]);
                decimal siteLoss = siteVisits * sitePricePerVisit;
                 totalMoneyLoss += siteLoss;
                Console.WriteLine(siteName);

            }
            Console.WriteLine($"Total Loss: {totalMoneyLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
