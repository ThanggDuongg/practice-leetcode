namespace Leetcode
{
    internal class _3397
    {
        public int MaxDistinctElements(int[] nums, int k)
        {
            Array.Sort(nums);
            var res = 0;
            var currValue = int.MinValue;

            foreach (var num in nums)
            {
                var candidate = Math.Max(num - k, currValue + 1);

                if (candidate <= num + k)
                {
                    res++;
                    currValue = candidate;
                }
            }

            return res;
        }
    }
}
