namespace Leetcode
{
    class _128
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            var set = new HashSet<int>(nums);

            var res = 0;
            foreach (var num in nums)
            {
                if (set.Contains(num - 1))
                {
                    continue;
                }

                var count = 1;
                while (set.Contains(num + count))
                {
                    count++;
                }

                res = Math.Max(res, count);
            }
            return res;
        }
    }
}
