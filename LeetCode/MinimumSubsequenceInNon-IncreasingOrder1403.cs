namespace LeetCode
{
    public class MinimumSubsequenceInNon_IncreasingOrder1403
    {
        public IList<int> MinSubsequenceSolution(int[] nums)
        {
            // massivlarni yaratish (saralangan (desc))
            Array.Sort(nums);
            int sum = nums.Aggregate((item1, item2) => item1 + item2);

            List<List<int>> arrays = new();
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> list = new List<int>();
                for (int k = i; k < nums.Length; k++)
                {
                    list.Add(nums[k]);
                }
                list.Reverse();
                arrays.Add(list);
            }
            arrays.Reverse();

            // Bizda arrays tayyor, endi uning har bir yig'indisining ikkilanganini
            // berilgan arrayning yig'indisi bilan solishtiramiz

            return arrays.FirstOrDefault(arr => 2 * arr.Sum() > sum);
        }
        
        public IList<int> MinSubsequence(int[] nums)
        {
            Array.Sort(nums);
            int sum = nums.Aggregate((item1, item2) => item1 + item2);

            List<List<int>> arrays = new();
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> list = new List<int>();
                for (int k = i; k < nums.Length; k++)
                {
                    list.Add(nums[k]);
                }
                list.Reverse();
                arrays.Add(list);
            }
            arrays.Reverse();

            return arrays.FirstOrDefault(arr => 2 * arr.Sum() > sum);
        }
    }
}
