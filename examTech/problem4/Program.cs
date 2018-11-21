using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,List<int>>> cashe = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, Dictionary<string, List<int>>> dataSets = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, List<int>> datasets2 = new Dictionary<string, List<int>>();
            string command;
            while ((command= Console.ReadLine())!= "thetinggoesskrra")
            {
                string[] commandArggs = command.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArggs.Length == 1)
                {
                    string dataSet = commandArggs[0];

                  
                    if (!dataSets.ContainsKey(dataSet))
                    {
                        foreach (var item in cashe)
                        {
                            if (item.Key == dataSet)
                            {
                                dataSets.Add(dataSet, new Dictionary<string, List<int>>());
                                datasets2.Add(dataSet, new List<int>());
                                foreach (var m in item.Value)
                                {
                                    dataSets[dataSet].Add(m.Key, m.Value);
                                    datasets2.Add(dataSet, m.Value);

                                }
                                
                            }
                            
                        }
                        if (!dataSets.ContainsKey(dataSet))
                        {
                            dataSets.Add(dataSet, new Dictionary<string, List<int>>());
                            datasets2.Add(dataSet, new List<int>());
                        }
                       
                    }
                }
                else
                {
                    string dataKey = commandArggs[0];
                    int dataSize = int.Parse(commandArggs[1]);
                    string dataSet = commandArggs[2];
                    if (dataSets.ContainsKey(dataSet))
                    {
                        dataSets[dataSet].Add(dataKey,new List<int>());
                        dataSets[dataSet][dataKey].Add(dataSize);
                        
                        datasets2[dataSet].Add(dataSize);

                    }
                    else
                    {
                        cashe.Add(dataSet, new Dictionary<string, List<int>>());
                        cashe[dataSet].Add(dataKey, new List<int>());
                        cashe[dataSet][dataKey].Add(dataSize);
                    }
                }
            }
            foreach (var item in datasets2.OrderBy(i=>i.Value.Sum()).Take(1))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Sum()}");
                foreach (var i in dataSets.Where(x=>x.Key == item.Key))
                {
                    Console.WriteLine($"$.{i.Value}");
                }
            }
        }
    }
}
