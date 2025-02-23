using System;

namespace MaximumStrongPairXORI2932;

public static class MaximumStrongPairXORI2932_Solution
{
    public static int MaximumStrongPairXor(int[] nums)
    {
        int maxXor = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                int x = nums[i];
                int y = nums[j];

                if (Math.Abs(x - y) <= Math.Min(x, y))
                {
                    int xorValue = x ^ y;
                    if (xorValue > maxXor)
                    {
                        maxXor = xorValue;
                    }
                }
            }
        }

        return maxXor;
    }
}