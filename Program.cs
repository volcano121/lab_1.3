using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "IK-21");
            dict.Add(2, "IK-22");
            dict.Add(3, "IK-23");
            dict.Add(4, "IK-22");
            dict.Add(5, "IK-24");
            Console.WriteLine("Initial dictionary:");
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            Dictionary<int, string> newDict = new Dictionary<int, string>();
            foreach (KeyValuePair<int, string> pair in dict)
            {
                if (!newDict.ContainsValue(pair.Value))
                {
                    newDict.Add(pair.Key, pair.Value);
                }
            }
            dict = newDict;
            Console.WriteLine("\nDictionary without duplicates:");
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            string json = JsonConvert.SerializeObject(dict);
            File.WriteAllText("D:\\Education\\Microsoft Visual Studio\\2022\\Projects\\lab1.2\\dictionary.json", json);
            Console.WriteLine("\nResult saved to dictionary.json");
            Console.ReadKey();
        }
    }
}
