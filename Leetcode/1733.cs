namespace Leetcode
{
    internal class _1733
    {
        public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < friendships.Length; i++)
            {
                var f1 = friendships[i][0] - 1;
                var f2 = friendships[i][1] - 1;
                if (!languages[f1].Intersect(languages[f2]).Any())
                {
                    set.Add(f1);
                    set.Add(f2);
                }
            }

            if (set.Count == 0)
            {
                return 0;
            }

            var minTech = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                var count = set.Count(friend => !languages[friend].Contains(i));
                minTech = Math.Min(minTech, count);
            }

            return minTech;
        }
    }
}
