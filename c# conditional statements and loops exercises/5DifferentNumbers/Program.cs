using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (Math.Abs (a-b) < 5)
            {
                Console.WriteLine($"No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int q = a; q <=b; q++)
                    {
                        for (int w = a; w <=b; w++)
                        {
                            for (int e = a; e <= b; e++)
                            {
                                for (int m = a; m <= b; m++)
                                {
                                    if ((i>=q)|| (q>=w) || (w>=e) || (e>=m))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Console.Write(i + " ");
                                        Console.Write(q + " ");
                                        Console.Write(w + " ");
                                        Console.Write(e + " ");
                                        Console.WriteLine(m);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
