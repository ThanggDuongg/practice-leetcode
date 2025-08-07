namespace Leetcode
{
    class _3375
    {
        public int MinOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            var res = 0;
            var cur = -1;
            foreach (var item in nums)
            {
                if (item < k)
                {
                    return -1;
                }
                else if (item != k && item != cur)
                {
                    res++;
                    cur = item;
                }
            }
            return res;
        }
    }
}
