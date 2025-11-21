namespace Leetcode
{
    internal class _3354
    {
        public int CountValidSelections(int[] nums)
        {
            int n = nums.Length,
                total = nums.Sum(),
                suffix = 0,
                ans = 0;

            for (int i = 0; i < n; i++)
            {
                var rightSum = total - suffix;

                if (nums[i] == 0)
                {
                    if (rightSum == suffix)
                    {
                        ans += 2;
                    }
                    else if (Math.Abs(rightSum - suffix) == 1)
                    {
                        ans += 1;
                    }
                }

                suffix += nums[i];
            }

            return ans;
        }
    }
}
