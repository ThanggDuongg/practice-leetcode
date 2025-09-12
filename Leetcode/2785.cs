using System.Text;

namespace Leetcode
{
    internal class _2785
    {
        public string SortVowels(string s)
        {
            Span<bool> isVowel = stackalloc bool[128];
            foreach (char c in "aeiouAEIOU")
            {
                isVowel[c] = true;
            }

            var vowels = new List<char>();
            foreach (char c in s)
            {
                if (isVowel[c])
                {
                    vowels.Add(c);
                }
            }

            vowels.Sort();

            var res = new StringBuilder(s.Length);
            int j = 0;
            foreach (char c in s)
            {
                if (isVowel[c])
                {
                    res.Append(vowels[j++]);
                }
                else
                {
                    res.Append(c);
                }
            }

            return res.ToString();
        }
    }
}
