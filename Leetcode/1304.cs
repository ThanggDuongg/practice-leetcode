namespace Leetcode
{
    internal class _1304
    {
        public int[] SumZero(int n)
        {
            var res = new int[n];
            int i = 0;

            if (n % 2 != 0)
            {
                res[i++] = 0;
            }

            while (i < n)
            {
                var temp = i + 1;
                res[i++] = temp;
                res[i++] = -temp;
            }

            return res;
        }
    }
}
