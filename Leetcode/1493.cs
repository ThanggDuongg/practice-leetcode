namespace Leetcode
{
    internal class _1493
    {
        public int LongestSubarray(int[] nums)
        {
            int res = 0,
                deletedCount = 0,
                left = 0,
                right = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    if (deletedCount == 0)
                    {
                        deletedCount++;
                    }
                    else
                    {
                        while (nums[left] != 0)
                        {
                            left++;
                        }
                        left++;
                    }
                }

                res = Math.Max(res, right - left + 1);
                right++;
            }

            return res;
        }
    }
}
