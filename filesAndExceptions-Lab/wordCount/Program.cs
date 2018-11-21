using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = 
                File.ReadAllText("words.txt")
                .ToLower()
                .Split();
            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { '\r', '\n', ' ', '-', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount[word] = 0;
               
            }
            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                
                }
            }
            
        }
    }
}
