using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split(new char[] {  '{', '}' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            Regex regex =  new Regex(@"([a-zA-Z]+)(.+)(\1)");
            int index = 0;
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                
               input = input.Replace(match.Groups[2].Value, placeholders[index]);
                index++;
            }
            Console.WriteLine(input);


        }
    }
}
