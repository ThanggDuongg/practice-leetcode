namespace Leetcode
{
    internal class _3027
    {
        public int NumberOfPairs(int[][] points)
        {
            var res = 0;

            Array.Sort(
                points,
                (a, b) =>
                {
                    if (a[0] == b[0])
                    {
                        return b[1].CompareTo(a[1]);
                    }
                    return a[0].CompareTo(b[0]);
                }
            );

            for (var i = 0; i < points.Length; i++)
            {
                var y1 = points[i][1];
                var minY = int.MinValue;
                for (var j = i + 1; j < points.Length; j++)
                {
                    var y2 = points[j][1];
                    if (minY < y2 && y2 <= y1)
                    {
                        res++;
                        minY = y2;
                        if (y1 == minY)
                        {
                            break;
                        }
                    }
                }
            }

            return res;
        }
    }
}
