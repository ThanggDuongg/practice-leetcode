namespace Leetcode
{
    internal class _3289
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            var index = 0;
            var res = new int[2];
            var duplicates = new bool[nums.Length - 2];
            foreach (var num in nums)
            {
                if (duplicates[num])
                {
                    res[index++] = num;
                }
                else
                {
                    duplicates[num] = true;
                }
            }

            return res;
        }
    }
}
