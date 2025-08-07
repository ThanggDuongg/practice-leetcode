using System.Text;

namespace Leetcode
{
    internal class _2311
    {
        public int LongestSubsequence(string s, int k)
        {
            int res = 0;
            var currentString = new StringBuilder();
            var countZero = s.Count(c => c == '0');

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];

                if (c == '0')
                {
                    currentString.Insert(0, '0');
                    res++;
                    countZero--;
                }
                else
                {
                    currentString.Insert(0, '1');
                    if (Convert.ToInt64(currentString.ToString(), 2) <= k)
                    {
                        res++;
                    }
                    else if (countZero > 0)
                    {
                        return res + countZero;
                    }
                    else
                    {
                        return res;
                    }
                }
            }

            return res;
        }
    }
}
