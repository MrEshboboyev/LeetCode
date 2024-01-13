using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ThousandSeparator1556
    {
        public string ReverseString(string txt)
        {
            string result = "";
            for (int i = txt.Length - 1; i >= 0; i--) 
            {
                result += txt[i];
            }
            return result;
        }

        public string ThousandSeparator(int n)
        {
            string res = "";
            
            string? str = ReverseString(n.ToString());
            for (int i = 0; i < str.Length; i++)
            {
                res += str[i];
                if((i+1) % 3 == 0) res += '.';
            }
            if (res[res.Length - 1] == '.')
            {
                res = res.Remove(res.Length - 1, 1);
            }
            return ReverseString(res);
        }
    }
}
