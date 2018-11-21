using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
                var result = new List<string>();
                foreach (var pairs in count)
                {
                    if (pairs.Value % 2 != 0)
                    {
                        result.Add(pairs.Key);
                    }
                }
                Console.WriteLine($"{String.Join(", ",result)}");
            
        }
    }
}
