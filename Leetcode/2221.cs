namespace Leetcode
{
    internal class _2221
    {
        public int TriangularSum(int[] nums)
        {
            var len = nums.Length - 1;
            var i = len - 1;

            while (i >= 0)
            {
                var j = 0;
                while (j <= i)
                {
                    nums[j] = (nums[j] + nums[j + 1]) % 10;
                    j++;
                }
                i--;
            }

            return nums[0];
        }
    }
}
