using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baking
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            var ingredientsCount = 0;

            while (ingredient != "Bake!")
            {
                ingredientsCount++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();

            }

            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
        }
    }
}
