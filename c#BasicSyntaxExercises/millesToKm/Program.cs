using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double milles = double.Parse(Console.ReadLine());
            double km = milles * 1.60934;
            Console.WriteLine($"{km:F2}");
        }
    }
}
