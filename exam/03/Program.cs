using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var group = Console.ReadLine();
            int countStudents = int.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            double price = 0;
            string kindOfsport = " ";

            // winter
            if (season == "Winter")
            {
                if (group == "boys")
                {
                    pricePerNight = 9.6;
                    Console.Write("Judo" + " ");
                    
                }
                else if (group == "girls")
                {
                    pricePerNight = 9.6;
                    Console.Write("Gymnastics" + " ");
                }
                else if (group == "mixed")
                {
                    pricePerNight = 10;
                    Console.Write("Ski" + " ");
                }
            }
            //Spring
            if (season == "Spring")
            {
                if (group == "boys")
                {
                    pricePerNight = 7.2;
                    Console.Write("Tennis" + " ");
                }
                else if (group == "girls")
                {
                    pricePerNight = 7.2;
                    Console.Write("Athletics" + " ");
                }
                else if (group == "mixed")
                {
                    pricePerNight = 9.5;
                    Console.Write("Cycling" + " ");
                }
            }
            //summer 
            if (season == "Summer")
            {
                if (group == "boys")
                {
                    pricePerNight = 15;
                    Console.Write("Football" + " ");
                }
                else if (group == "girls")
                {
                    pricePerNight = 15;
                    Console.Write("Volleyball" + " ");
                }
                else if (group == "mixed")
                {
                    pricePerNight = 20;
                    Console.Write("Swimming" + " ");
                }
            }
            price = countNights * countStudents * pricePerNight;
            if (countStudents >= 50)
            {
                price -= price * 0.5;
            }
            else if (countStudents >= 20 && countStudents < 50)
            {
                price -= price * 0.15;
            }
            else if (countStudents >= 10 && countStudents < 20)
            {
                price -= price * 0.05;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
