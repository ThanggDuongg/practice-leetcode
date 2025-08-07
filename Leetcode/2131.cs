namespace Leetcode
{
    class _2131
    {
        public int LongestPalindrome(string[] words)
        {
            var map = new int[26, 26];
            var res = 0;

            foreach (var word in words)
            {
                var c1 = word[0] - 'a';
                var c2 = word[1] - 'a';

                if (map[c2, c1] != 0)
                {
                    map[c2, c1]--;
                    res += 4;
                }
                else
                {
                    map[c1, c2]++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (map[i, i] != 0)
                {
                    res += 2;
                    return res;
                }
            }

            return res;
        }
    }
}
