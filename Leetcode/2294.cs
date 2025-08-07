namespace Leetcode
{
    class _2294
    {
        public int PartitionArray(int[] nums, int k)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var res = 1;
            Array.Sort(nums);

            int i = 1,
                thres = nums[0] + k;
            while (i < nums.Length)
            {
                if (nums[i] > thres)
                {
                    res++;
                    thres = nums[i] + k;
                }
                i++;
            }

            return res;
        }
    }
}
