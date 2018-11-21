using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakinging
{
    class Program
    {
        static void Main(string[] args)
        {
            int countofing = 0;
            for (int i = 0; i < 100; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake")
                {
                    Console.WriteLine($"Preparing cake with {countofing} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
                countofing++;
                
            }
        }
    }
}
