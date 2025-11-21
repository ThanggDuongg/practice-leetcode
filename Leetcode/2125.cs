namespace Leetcode
{
    internal class _2125
    {
        public int NumberOfBeams(string[] bank)
        {
            int res = 0,
                prev = 0;

            foreach (var line in bank)
            {
                var count = line.Count(c => c == '1');
                if (count > 0)
                {
                    res += prev * count;
                    prev = count;
                }
            }
            return res;
        }
    }
}
