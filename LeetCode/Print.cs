using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Print
    {
        public static void PrintDictionary(Dictionary<char, int> dict)
        {
            foreach(KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
