using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevarageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyPer100ml = double.Parse(Console.ReadLine());
            double sugarPer100ml = double.Parse(Console.ReadLine());
            double energyPer1ml = energyPer100ml / 100;
            double sugarPer1ml = sugarPer100ml / 100;
            Console.WriteLine($"{volume}ml {name}:");
           Console.WriteLine($"{energyPer1ml * volume}kcal, {sugarPer1ml * volume}g sugars ");
        }
    }
}
