using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RedistributeCharacterstoMakeAllStringsEqual1897
    {
        public bool MakeEqual(string[] words)
        {
            int length = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if(dict.ContainsKey(c))
                    {
                        dict[c] += 1;
                    }
                    else
                    {
                        dict.Add(c, 1);
                    }
                }
                length++;
            }
            if(length == 1) return true; 

            List<int> valueList= dict.Values.ToList();
            foreach (int value in valueList)
            {
                if (value % length != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
