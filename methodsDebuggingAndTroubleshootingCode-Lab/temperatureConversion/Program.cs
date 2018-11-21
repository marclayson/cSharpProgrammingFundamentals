using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenhaitDegree = double.Parse( Console.ReadLine());
            double celciusDegree = FahrenheitToCelsius(fahrenhaitDegree);
            Console.WriteLine($"{celciusDegree:F2}");


        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
           return (fahrenheit - 32) * 5 / 9; ;

        }
    }
}
