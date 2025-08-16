namespace Leetcode
{
    internal class _1323
    {
        public int Maximum69Number(int num)
        {
            var str = num.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '6')
                {
                    return int.Parse(string.Concat(str.AsSpan(0, i), "9", str.AsSpan(i + 1)));
                }
            }
            return num;
        }
    }
}
