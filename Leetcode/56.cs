namespace Leetcode
{
    class _56
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            var res = new List<int[]>();

            foreach (var interval in intervals)
            {
                if (res.Count <= 0 || interval[0] > res[^1][1])
                {
                    res.Add(interval);
                }
                else
                {
                    res[^1][1] = Math.Max(res[^1][1], interval[1]);
                }
            }

            return [.. res];
        }
    }
}
