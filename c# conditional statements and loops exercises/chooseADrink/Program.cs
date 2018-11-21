using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
         else   if (profession == "Businessman")
            {
                Console.WriteLine("Coffee");
            }
         else   if (profession == "Businesswomen")
            {
                Console.WriteLine("Coffee");
            }
       else     if (profession == "SoftUni Students")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
