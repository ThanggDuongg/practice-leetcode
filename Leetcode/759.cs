namespace Leetcode
{
    class _759
    {
        public int[][] EmployeeFreeTime(int[][][] schedule)
        {
            var intervals = new List<int[]>();
            foreach (var employee in schedule)
            {
                foreach (var item in employee)
                {
                    intervals.Add(item);
                }
            }

            Array.Sort(intervals.ToArray(), (x, y) => x[0].CompareTo(y[0]));
            var merged = new List<int[]>();

            foreach (var interval in intervals)
            {
                if (interval.Length <= 0 || interval[0] >= merged[^1][1])
                {
                    merged.Add(interval);
                }
                else
                {
                    merged[^1][1] = Math.Max(merged[^1][1], interval[1]);
                }
            }

            var res = new List<int[]>();
            for (int i = 1; i < merged.Count; i++)
            {
                res.Add([merged[i - 1][1], merged[i][0]]);
            }
            return [.. res];
        }
    }
}
