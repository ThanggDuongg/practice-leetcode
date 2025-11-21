namespace Leetcode
{
    internal class _1930
    {
        public int CountPalindromicSubsequence(string s)
        {
            var res = 0;
            var dict = new Dictionary<char, (int Count, int FirstIndex, int LastIndex)>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.TryGetValue(s[i], out var tuple))
                {
                    dict[s[i]] = (1, i, i);
                }
                else
                {
                    dict[s[i]] = (tuple.Count + 1, tuple.FirstIndex, i);
                }
            }

            foreach (var item in dict)
            {
                if (item.Value.Count == 1)
                {
                    continue;
                }
                else if (item.Value.Count >= 2)
                {
                    var set = new bool[26];
                    for (int i = item.Value.FirstIndex + 1; i < item.Value.LastIndex; i++)
                    {
                        if (s[i] != item.Key)
                        {
                            set[s[i] - 'a'] = true;
                        }
                    }
                    int cnt = 0;
                    for (int i = 0; i < 26; i++)
                    {
                        if (set[i])
                        {
                            cnt++;
                        }
                    }

                    res += cnt;
                }

                if (item.Value.Count >= 3)
                {
                    res += 1;
                }
            }

            return res;
        }
    }
}
