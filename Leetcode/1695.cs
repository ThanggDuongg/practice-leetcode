namespace Leetcode
{
    class _1695
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            int res = 0,
                currentSum = 0,
                left = 0,
                right = 0;
            var seen = new HashSet<int>();
            while (right < nums.Length)
            {
                if (!seen.Contains(nums[right]))
                {
                    seen.Add(nums[right]);
                    currentSum += nums[right];
                    res = Math.Max(res, currentSum);
                    right++;
                }
                else
                {
                    while (seen.Contains(nums[right]))
                    {
                        seen.Remove(nums[left]);
                        currentSum -= nums[left];
                        left++;
                    }
                }
            }
            return res;
        }
    }
}
