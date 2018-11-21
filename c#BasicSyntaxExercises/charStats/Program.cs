using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int curHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int curEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            

            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new string('|', curHealth));
            Console.Write(new string('.', maxHealth - curHealth));
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string('|', curEnergy));
            Console.Write(new string('.', maxEnergy - curEnergy));
            Console.WriteLine("|");

        }
    }
}
