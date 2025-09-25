namespace Leetcode
{
    internal class _120
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0)
            {
                return 0;
            }

            var len = triangle.Count;
            Span<int> dp = stackalloc int[len];
            for (var i = 0; i < len; i++)
            {
                dp[i] = triangle[len - 1][i];
            }

            for (var i = len - 2; i >= 0; i--)
            {
                for (var j = 0; j <= i; j++)
                {
                    dp[j] = triangle[i][j] + Math.Min(dp[j], dp[j + 1]);
                }
            }

            return dp[0];
        }
    }
}
