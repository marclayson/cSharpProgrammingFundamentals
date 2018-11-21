using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
          
            for (int i = M; i >= 1; i--)
            {
                for (int k = N; k >= 1; k--)
                {
                    for (int j = L; j >= 1; j--)
                    {
                        
                     int   chislo = 100 * i + 10 * k + j;

                        if (chislo % 3 == 0)
                        {
                            specialNumber += 5;
                           ;

                        }
                        else if (j == 5)
                        {
                            specialNumber -= 2;
                           ;
                            

                        }
                        else if (chislo % 2 == 0)
                        {
                            specialNumber *= 2;
                            ;                              
                        }
                        
                        
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }








                    }
                }

            }
        
            
            
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            
        }
    }
}
