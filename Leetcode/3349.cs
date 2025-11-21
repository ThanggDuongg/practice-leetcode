namespace Leetcode
{
    internal class _3349
    {
        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            if (nums.Count < k * 2)
            {
                return false;
            }

            int i = 0;
            while (i + 2 * k <= nums.Count)
            {
                int a = i,
                    b = i + k;
                if (b >= nums.Count)
                {
                    return false;
                }

                if (IsIncreasing(nums, a, k) && IsIncreasing(nums, b, k))
                {
                    return true;
                }
                i++;
            }

            return false;
        }

        private bool IsIncreasing(IList<int> nums, int start, int k)
        {
            for (int i = start; i < start + k; i++)
            {
                if (nums[i] >= nums[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
