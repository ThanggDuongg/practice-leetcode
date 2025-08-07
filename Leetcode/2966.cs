namespace Leetcode
{
    class _2966
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            if (nums.Length % 3 != 0)
            {
                return [];
            }
            Array.Sort(nums);
            var res = new int[nums.Length / 3][];
            for (int i = 0; i < nums.Length; i += 3)
            {
                if (nums[i + 2] - nums[i] > k)
                {
                    return [];
                }
                res[i / 3] = [nums[i], nums[i + 1], nums[i + 2]];
            }

            return res;
        }
    }
}
