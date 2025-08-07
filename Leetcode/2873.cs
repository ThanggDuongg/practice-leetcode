namespace Leetcode
{
    class _2873
    {
        public long MaximumTripletValue(int[] nums)
        {
            long maxMul = 0,
                maxK = 0,
                maxDiff = 0;
            foreach (var item in nums)
            {
                maxMul = Math.Max(maxMul, maxDiff * item);
                maxDiff = Math.Max(maxDiff, maxK - item);
                maxK = Math.Max(maxK, item);
            }
            return maxMul;
        }
    }
}
