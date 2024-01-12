using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray88
    {
        public int[] BubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for(i = 0; i < n - 1; i++)
            {
                swapped = false;
                for(j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        //swap arr[j] and arr[j+1] 
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if(swapped == false)
                {
                    break;
                }
            }
            return arr;
        }
        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[m + i] = nums2[i];
                }
            }
            return BubbleSort(nums1, n+m);
        }
    }
}
