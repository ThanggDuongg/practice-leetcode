namespace Leetcode
{
    class _2461
    {
        public long MaximumSubarraySum(int[] nums, int k)
        {
            long res = 0,
                curSum = 0;
            int start = 0;
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                curSum += nums[i];
                dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
                if (i - start + 1 == k)
                {
                    if (dict.Count == k)
                    {
                        res = Math.Max(res, curSum);
                    }
                    dict[nums[start]]--;
                    if (dict[nums[start]] == 0)
                    {
                        dict.Remove(nums[start]);
                    }

                    curSum -= nums[start];
                    start++;
                }
            }

            return res;
        }
    }
}
