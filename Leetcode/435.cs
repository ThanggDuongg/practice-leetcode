namespace Leetcode
{
    class _435
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));
            int end = intervals[0][1],
                i = 1,
                count = 1;

            while (i < intervals.Length)
            {
                if (intervals[i][0] >= end)
                {
                    count++;
                    end = intervals[i][1];
                }
                i++;
            }

            return intervals.Length - count;
        }
    }
}
