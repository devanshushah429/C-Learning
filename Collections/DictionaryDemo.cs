using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class DictionaryDemo
    {
        Dictionary<int, String> dict = new Dictionary<int, String>() { };
        SortedDictionary<string, String> sortedDict = new SortedDictionary<string, string>()
        {
            { "India", "Delhi" },
            { "Pakistan", "Lahore" },
            { "Australia", "Jakarta" }
        };
        public void UseAllMethods()
        {
            // Adding a key value pair in dictionary
            dict.Add(1, "First");
            dict.Add(2, "Second");
            dict.Add(3, "Third");
            dict.Add(4, "Fourth");

            // Retriving element with key
            Console.WriteLine(dict[2]);

            // Count the elements in dictionary
            Console.WriteLine(dict.Count);

            // Check that key is available in hash map
            Console.WriteLine("Constains key 2? " + dict.ContainsKey(2));

            // Check that key is available in hash map
            Console.WriteLine("Contains value Second? " + dict.ContainsValue("Second"));

            // Get all the keys
            Console.WriteLine(String.Join(",", dict.Keys));

            // using ENumerator
            Dictionary<int, string>.Enumerator en = dict.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current.Key + "->" + en.Current.Value);
            }


            // remove key value pair using key and return true or false if removed or not respectively
            dict.Remove(4);
            Console.WriteLine(dict.Remove(15));
            DisplayDictionary();
        }

        public void DisplayDictionary()
        {
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(key + "->" + dict[key]);
            }
        }

        public void UseAllMethodsSortedDict()
        {
            // keeps keys in a sorted manner
            sortedDict.Add("Japan", "Tokyo");
            foreach (var keyVal in sortedDict)
            {
                Console.WriteLine(keyVal.Key + " -> " + keyVal.Value);
            }
        }
    }
}
