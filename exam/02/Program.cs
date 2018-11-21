using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int countPuzzels = int.Parse(Console.ReadLine());
            int countSpeakingDolls = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double puzzel = 2.60;
            int speakingDolls = 3;
            double bear = 4.10;
            double minions = 8.20;
            int truck = 2;

            int allGames = countBears + countMinions + countPuzzels + countSpeakingDolls + countTrucks;
            double money = countBears * bear + countMinions * minions + countPuzzels * puzzel + countSpeakingDolls * speakingDolls + countTrucks * truck;
            if (allGames >= 50)
            {
                money = money - money * 0.25;
            }
            money = money - money * 0.1;
            if (money >= priceTrip)
            {
                Console.WriteLine($"Yes! {money - priceTrip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceTrip - money:f2} lv needed.");
            }
        }
    }
}
