namespace Leetcode
{
    internal class _611
    {
        public int TriangleNumber(int[] nums)
        {
            var res = 0;
            if (nums.Length < 3)
            {
                return res;
            }

            Array.Sort(nums);

            for (int i = nums.Length - 1; i >= 2; i--)
            {
                int left = 0,
                    right = i - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] > nums[i])
                    {
                        res += right - left;
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return res;
        }
    }
}
