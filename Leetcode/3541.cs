namespace Leetcode
{
    internal class _3541
    {
        public int MaxFreqSum(string s)
        {
            var n = 26;
            var lowerAlphabet = new int[n];
            foreach (var item in s)
            {
                lowerAlphabet[item - 'a']++;
            }
            int maxConsonant = 0,
                maxVowel = 0;
            var vowels = "aeiou";
            for (int i = 0; i < n; i++)
            {
                if (vowels.Contains((char)(i + 'a')))
                {
                    maxVowel = Math.Max(maxVowel, lowerAlphabet[i]);
                }
                else
                {
                    maxConsonant = Math.Max(maxConsonant, lowerAlphabet[i]);
                }
            }

            return maxConsonant + maxVowel;
        }
    }
}
