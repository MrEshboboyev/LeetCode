using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbersWithUniqueDigits357;

public static class CountNumbersWithUniqueDigits357_Solution
{
    public static int CountNumbersWithUniqueDigits(int n)
    {
        if (n == 0) return 1;
        if (n == 1) return 10;

        int result = 10; // for n = 1
        int uniqueDigits = 9;
        int availableNumber = 9;

        for (int i = 2; i <= n && availableNumber > 0; i++)
        {
            uniqueDigits *= availableNumber;
            result += uniqueDigits;
            availableNumber--;
        }

        return result;
    }
}


