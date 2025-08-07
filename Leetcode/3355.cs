namespace Leetcode
{
    class _3355
    {
        public bool IsZeroArray(int[] nums, int[][] queries)
        {
            var array = new int[nums.Length + 1];

            foreach (var query in queries)
            {
                array[query[0]]++;
                array[query[1] + 1]--;
            }

            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += array[i];
                if (nums[i] > count)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
