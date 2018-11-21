using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("@" + new string(' ', ((2*n) - 4) /2) + "@" + new string(' ', ((2 * n) - 4) / 2) + "@");
            Console.WriteLine("*" +  "*" + new string(' ', ((2 * n) - 6) / 2  ) + "*" + new string(' ', ((2 * n) - 6) / 2) +
                   "*" +  "*");
           
          for (int i = 0; i < (n + 2) /4 ; i++)
            {

             Console.WriteLine("*" + new string('.',i+1 ) + "*" + new string(' ',n -5 - 2*i) + "*" + new string('.',2 * i + 1) + "*" + new string(' ',  n - 5 -  2*i ) +
                  "*" + new string('.', i+1 ) + "*");
            }
            Console.WriteLine("*" + new string('.', (2*n - 10)/2) + "*" + new string('.', 2 * n - 11)+ "*" + new string('.', (2 * n - 10) / 2) + "*");
            Console.WriteLine("*" +new string('.', n /2) + new string ('*',(n + 2)  /4) + "." + new string('*', (n + 2) / 4) + new string('.', n / 2) + "*");
            for (int i = 0; i < n/4; i++)
            {
                Console.WriteLine(new string ('*', 2 * n -1));
            }
        }
    }
}
