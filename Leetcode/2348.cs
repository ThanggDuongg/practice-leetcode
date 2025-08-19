namespace Leetcode
{
    internal class _2348
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            int zerorCount = 0;
            long res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zerorCount++;
                }
                else
                {
                    res += (long)zerorCount * (zerorCount + 1) / 2;
                    zerorCount = 0;
                }
            }

            if (zerorCount != 0)
            {
                res += (long)zerorCount * (zerorCount + 1) / 2;
            }
            return res;
        }
    }
}
