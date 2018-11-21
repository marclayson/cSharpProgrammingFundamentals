using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ',
                '!','?', '.', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> removedWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            { 
                string word = words[i];
                char[] wordInChar = word.ToCharArray();
                Array.Reverse(wordInChar);
                string reversedWord = new string(wordInChar);
                if (word == reversedWord)
                {
                    
                    removedWords.Add(word);
                  


                }
                
                
            }
            Console.WriteLine(string.Join(", ",removedWords));
            
        }
    }
}
