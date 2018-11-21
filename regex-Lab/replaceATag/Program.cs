using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace replaceATag
{
    class Program
    {
        static void Main(string[] args)
        { var text = Console.ReadLine();
            while (text !="end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replacement = @"[URL href=$1]$2[/URL]";
               string replaced = Regex.Replace(text, pattern, replacement);
                Console.WriteLine(replaced);
                text = Console.ReadLine();
            }
            
        }
    }
}
