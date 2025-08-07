namespace Leetcode
{
    class _2200
    {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            var res = new List<int>();
            int i = 0,
                j = 0,
                n = nums.Length;
            while (i < n)
            {
                if (nums[i] == key)
                {
                    j = Math.Max(j, i - k);
                    while (j <= Math.Min(n - 1, i + k))
                    {
                        res.Add(j);
                        j++;
                    }
                }
                i++;
            }
            return res;
        }
    }
}
