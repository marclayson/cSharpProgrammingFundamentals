using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
           double capacityOfStadium = double.Parse(Console.ReadLine());
            double allSpectators = double.Parse(Console.ReadLine());
            double broiA = 0;
            double broiB = 0;
            double broiV = 0;
            double broiG = 0;

            for (int i = 0; i < allSpectators; i++)
            {
                char sector =char.Parse ( Console.ReadLine());
                if (sector == 'A')
                {
                    broiA++;
                }
                else if (sector == 'B')
                {
                    broiB++;
                }
                else if (sector == 'V')
                {
                    broiV++;
                }
                else if (sector == 'G')
                {
                    broiG++;
                }
            }
            Console.WriteLine($"{broiA /allSpectators * 100:f2}%");
            Console.WriteLine($"{broiB / allSpectators * 100:f2}%");
            Console.WriteLine($"{broiV / allSpectators * 100:f2}%");
            Console.WriteLine($"{broiG / allSpectators * 100:f2}%");
            Console.WriteLine($"{(allSpectators /capacityOfStadium) * 100:f2}%");
        }
    }
}
