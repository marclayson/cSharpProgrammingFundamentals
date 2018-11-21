using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calories
{
    class Program
    {
        static void Main(string[] args)
        {

            int countIng = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 1; i <= countIng; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                {
                    calories =calories + 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    calories = calories + 150;
                }
                else if (ingredient == "salami")
                {
                    calories = calories + 600;
                }
                else if (ingredient == "pepper")
                {
                    calories = calories + 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
