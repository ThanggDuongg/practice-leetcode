namespace Leetcode
{
    internal class _3186
    {
        public long MaximumTotalDamage(int[] power)
        {
            Array.Sort(power);
            var dict = new Dictionary<int, int>();
            foreach (var p in power)
            {
                if (!dict.ContainsKey(p))
                {
                    dict[p] = 0;
                }

                dict[p] += p;
            }

            var damage = dict.Keys.OrderBy(k => k).ToArray();
            var sum = damage.Select(d => dict[d]).ToArray();

            var dp = new long[dict.Count];
            dp[0] = sum[0];
            for (int i = 1; i < dict.Count; i++)
            {
                var j = i - 1;
                while (j >= 0 && damage[j] >= damage[i] - 2)
                {
                    j--;
                }

                if (j >= 0)
                {
                    dp[i] = Math.Max(dp[i - 1], dp[j] + sum[i]);
                }
                else
                {
                    dp[i] = Math.Max(dp[i - 1], sum[i]);
                }
            }

            return dp[^1];
        }
    }
}
