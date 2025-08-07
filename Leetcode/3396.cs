namespace Leetcode
{
    class _3396
    {
        public int MinimumOperations(int[] nums)
        {
            var existed = new HashSet<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (existed.Contains(nums[i]))
                {
                    return i / 3 - 1;
                }
                else
                {
                    existed.Add(nums[i]);
                }
            }
            return 0;
        }
    }
}
