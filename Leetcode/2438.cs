namespace Leetcode
{
    internal class _2438
    {
        public int[] ProductQueries(int n, int[][] queries)
        {
            var result = new int[queries.Length];
            var bits = new List<int>();
            int t = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    bits.Add(1 << t);
                }
                n >>= 1;
                t++;
            }
            for (int i = 0; i < queries.Length; i++)
            {
                var (start, end) = (queries[i][0], queries[i][1]);
                long product = 1;
                for (int j = start; j <= end; j++)
                {
                    product = (product * bits[j]) % 1000000007;
                }
                result[i] = (int)product;
            }

            return result;
        }
    }
}
