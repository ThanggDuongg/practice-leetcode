using System.Text;

namespace Leetcode
{
    internal class _166
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                return "0";
            }

            var res = new StringBuilder();
            if ((numerator < 0) ^ (denominator < 0))
            {
                res.Append('-');
            }

            long num = Math.Abs((long)numerator);
            long den = Math.Abs((long)denominator);
            res.Append(num / den);

            var rem = num % den;
            if (rem == 0)
            {
                return res.ToString();
            }

            res.Append('.');
            var map = new Dictionary<long, int>();
            while (rem != 0)
            {
                if (map.TryGetValue(rem, out int idx))
                {
                    res.Insert(idx, '(');
                    res.Append(')');
                    break;
                }
                map[rem] = res.Length;
                rem *= 10;
                res.Append(rem / den);
                rem %= den;
            }

            return res.ToString();
        }
    }
}
