namespace Leetcode
{
    class _3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();
            int start = 0,
                res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                dict[s[i]] = dict.GetValueOrDefault(s[i], 0) + 1;

                while (dict[s[i]] > 1)
                {
                    dict[s[start]]--;
                    if (dict[s[start]] == 0)
                    {
                        dict.Remove(s[start]);
                    }
                    start++;
                }

                res = Math.Max(res, i - start + 1);
            }

            return res;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            var dict = new Dictionary<char, int>();
            int start = 0,
                res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out int value) && value >= start)
                {
                    start = value + 1;
                }
                dict[s[i]] = i;
                res = Math.Max(res, i - start + 1);
            }

            return res;
        }
    }
}
