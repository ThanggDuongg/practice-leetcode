namespace Leetcode
{
    class _3085
    {
        public int MinimumDeletions(string word, int k)
        {
            var freq = new Dictionary<char, int>();

            foreach (var c in word)
            {
                freq[c] = freq.GetValueOrDefault(c, 0) + 1;
            }

            int res = word.Length;
            foreach (int a in freq.Values)
            {
                int deleted = 0;
                foreach (int b in freq.Values)
                {
                    if (a > b)
                    {
                        deleted += b;
                    }
                    else if (b > a + k)
                    {
                        deleted += b - (a + k);
                    }
                }
                res = Math.Min(res, deleted);
            }
            return res;
        }
    }
}
