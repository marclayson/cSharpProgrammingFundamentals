using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakiq = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double priceRakiq = priceWhiskey / 2;
            double priceWine = priceRakiq - priceRakiq * 0.4;
            double priceBeer = priceRakiq - priceRakiq * 0.8;

            double sumRakiq = rakiq * priceRakiq;
            double sumBeer = beer * priceBeer;
            double sumWine = wine * priceWine;
            double sumWhiskey = whiskey* priceWhiskey;
            double allMoney = sumBeer + sumRakiq + sumWhiskey + sumWine;
            Console.WriteLine($"{allMoney:f2}");

        }
    }
}
