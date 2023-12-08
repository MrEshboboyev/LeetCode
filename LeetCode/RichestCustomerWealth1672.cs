using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RichestCustomerWealth1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                // Sum of the array elements
                for(int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }
                list.Add(sum);
            }
            return list.Max();
        }

        public void PrintArray(int[][] accounts)
        {
            // Display the array elements:
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < accounts[i].Length; j++)
                    Console.Write(accounts[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
