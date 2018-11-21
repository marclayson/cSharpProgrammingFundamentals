using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintHeader(count);
            PrintBody(count);
            PrintFooter(count);

        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintBody(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n -1 ; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
