using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SortingSentence1859
    {
        public string SortSentence(string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            foreach (string word in s.Split(' '))
            {
                dict.Add(word[word.Length - 1], word.Remove(word.Length - 1));
            }

            var list = dict.Keys.ToList();
            list.Sort();

            // result string 
            string res = "";
            foreach (char c in list)
            {
                res += dict[c] + " ";
            }
            return res.Remove(res.Length - 1);
        }
    }
}
