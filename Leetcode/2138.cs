using System.Text;

namespace Leetcode
{
    class _2138
    {
        public string[] DivideString(string s, int k, char fill)
        {
            var res = new string[(s.Length + k - 1) / k];
            int i = 0;

            while (i < s.Length)
            {
                res[i / k] += s[i];
                i++;
            }

            if (res[^1].Length < k)
            {
                var tempString = new StringBuilder(res[^1]);
                for (int j = res[^1].Length; j < k; j++)
                {
                    tempString.Append(fill);
                }
                res[^1] = tempString.ToString();
            }

            return res;
        }
    }
}
