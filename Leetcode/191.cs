namespace Leetcode
{
    internal class _191
    {
        public int HammingWeight(int n)
        {
            int res = 0;

            while (n != 0)
            {
                res++;
                n &= (n - 1);
            }

            return res;
        }
    }
}
