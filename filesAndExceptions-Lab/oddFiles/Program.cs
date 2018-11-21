using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace oddFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            var oddLines = lines.Where((line, i) => i % 2 == 1);
            File.WriteAllLines("oddlines.txt", oddLines);
        }
    }
}
