using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int mathPower = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, mathPower);
            Console.WriteLine(result);

        }

        static double RaiseToPower(double number, int mathPower)
        {
           
                double result = 1;
                for (int i = 1; i <= mathPower; i++)
                {
                    result = result * number;
                }
                return result;
            
        }
    }
}
