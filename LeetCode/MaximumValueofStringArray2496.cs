using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaximumValueofStringArray2496
    {
        public int MaximumValue(string[] strs)
        {
            List<int> list = new List<int>();
            foreach (string str in strs)
            {
                if(!int.TryParse(str, out int result))
                {
                    list.Add(str.Length);
                }
                else
                {
                    list.Add(result);
                }
            }
            return list.Max();
        }

        public void IsLetters(string str)
        {
            if (int.TryParse(str, out int result))
            {
                Console.WriteLine($"Conversion successful. Result: {result}");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        public int SumOfDigits(string str)
        {
            int sum = 0;
            foreach (char c in str)
            {
                sum += (int)char.GetNumericValue(c);
            }
            return sum;
        }
    }
}
