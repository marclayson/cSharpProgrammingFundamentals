using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restorantDiscout
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string Hall = "";
            double price = 0;
            double discount = 0;
            int hallprice = 0;
            double pricePerPerson = 0;
            int packageprice = 0;
            if (numberOfPeople <= 50)
            {
                Hall = "Small Hall";
                hallprice = 2500;
                if (package=="Normal")
                {
                    packageprice = 500;
                    discount = (hallprice + packageprice)*0.05;
                    price = (packageprice + hallprice) - discount ;

                    pricePerPerson = price / numberOfPeople;
                }
                else if (package == "Gold")
                {
                    packageprice = 750;
                    discount = (hallprice + packageprice) * 0.1;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                else if (package == "Platinum")
                {
                    packageprice = 1000;
                    discount = (hallprice + packageprice) * 0.15;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (numberOfPeople >50 && numberOfPeople <=100)
            {
                Hall = "Terrace";
                hallprice = 5000;
                if (package == "Normal")
                {
                    packageprice = 500;
                    discount = (hallprice + packageprice) * 0.05;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                else if (package == "Gold")
                {
                    packageprice = 750;
                    discount = (hallprice + packageprice) * 0.1;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                else if (package == "Platinum")
                {
                    packageprice = 1000;
                    discount = (hallprice + packageprice) * 0.15;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (numberOfPeople >100 && numberOfPeople <= 120)
            {
                Hall = "Great Hall";
                hallprice =7500;
                if (package == "Normal")
                {
                    packageprice = 500;
                    discount = (hallprice + packageprice) * 0.05;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                else if (package == "Gold")
                {
                    packageprice = 750;
                    discount = (hallprice + packageprice) * 0.1;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                else if (package == "Platinum")
                {
                    packageprice = 1000;
                    discount = (hallprice + packageprice) * 0.15;
                    price = (packageprice + hallprice) - discount;

                    pricePerPerson = price / numberOfPeople;
                }
                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (numberOfPeople >=120)
            {
                Console.WriteLine($"We do not have an appropriate hall.");
                
            }

            
        }
    }
}
