namespace LeetCode
{
    public class FindPivotIndex724
    {
        public int PivotIndexSolution(int[] nums)
        {
            // index o'zigacha bo'lgan elementlarni hisoblaydi, ichkaridagi sikl -> undak keyingi elementlarni hisoblaydi
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("\nsumLeft section : ");
                // left sum
                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += nums[k];
                }
                Console.Write(sumLeft);


                Console.WriteLine("\nsumRight section : ");
                // right sum
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sumRight += nums[j];
                }
                Console.WriteLine(sumRight);

                if (sumLeft == sumRight)
                {
                    Console.WriteLine($"Pivot index : {i}; Left : {sumLeft}, Right : {sumRight}");
                }
                sumLeft = 0;
                sumRight = 0;
            }

            return -1;
        }

        public int PivotIndex(int[] nums)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // left sum
                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += nums[k];
                }

                // right sum
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sumRight += nums[j];
                }

                if (sumLeft == sumRight)
                {
                    return i;
                }
                sumLeft = 0;
                sumRight = 0;
            }

            return -1;
        }
    }
}
