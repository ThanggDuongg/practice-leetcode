namespace Leetcode
{
    internal class _338
    {
        public int[] CountBits(int n)
        {
            var res = new int[n + 1];
            res[0] = 0;
            for (int i = 0; i <= n; i++)
            {
                res[i] = res[i >> 1] + (i & 1);
            }
            return res;
        }
    }
}
