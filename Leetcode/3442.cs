namespace Leetcode
{
    class _3442
    {
        public int MaxDifference(string s)
        {
            if (s.Length <= 0)
            {
                return 0;
            }
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!dict.TryGetValue(c, out int value))
                {
                    value = 0;
                    dict[c] = value;
                }
                dict[c] = ++value;
            }
            int max = int.MinValue,
                min = int.MaxValue;

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0 && item.Value > max)
                {
                    max = item.Value;
                }
                if (item.Value % 2 == 0 && item.Value < min)
                {
                    min = item.Value;
                }
            }
            return max - min;
        }
    }
}
