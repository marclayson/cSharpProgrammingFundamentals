using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();
            string command ;
            int startIndex2;
            string newDevider;
            

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commandArggs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArggs[0] == "merge")
                {
                    int startIndex =int.Parse( commandArggs[1]);
                    int endIndex = int.Parse(commandArggs[2]);

                    if (startIndex < 0 || startIndex >= data.Count)
                    {
                        startIndex = 0;
                    }
                     if (endIndex < 0 || endIndex > data.Count)
                    {
                        endIndex = data.Count - 1;
                    }
                        startIndex2 = startIndex;
                        for (int i = startIndex ; i < endIndex; i++)
                        {
                            data[startIndex2] += data[i + 1];
                            
                        }
                        data.RemoveRange(startIndex2 + 1, endIndex - startIndex2);
                    
                    
                   
                }

                else if (commandArggs[0] == "divide")
                {
                    int index =int.Parse( commandArggs[1]);
                    int partitions = int.Parse(commandArggs[2]);

                    string devider = data[index];
                    StringBuilder sb = new StringBuilder();
                   
                    
                    if (devider.Length % partitions == 0)
                    {
                        int numbers = devider.Length / partitions;
                        char[] charsInDevider = devider.ToCharArray();
                        for (int i = 0; i < charsInDevider.Length; i+=numbers)
                        {
                            //newDevider.Add( devider.Substring(i, numbers));
                            sb.Append(devider.Substring(i, numbers) + " ");
                        }
                         newDevider = sb.ToString();
                        data.RemoveAt(index);
                        
                        data[index] += newDevider;

                    }

                }
            }
            Console.WriteLine(string.Join(" ",data));
        }
    }
} 