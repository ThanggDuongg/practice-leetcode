namespace Leetcode
{
    class _1399
    {
        public int CountLargestGroup(int n)
        {
            var freq = new Dictionary<int, int>();
            var max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var sum = SumDigits(i);
                var count = freq.GetValueOrDefault(sum, 0) + 1;
                freq[sum] = count;
                max = Math.Max(max, count);
            }

            var res = 0;
            foreach (var item in freq)
            {
                if (item.Value == max)
                {
                    res++;
                }
            }

            return res;
        }

        public int SumDigits(int x)
        {
            var res = 0;
            while (x > 0)
            {
                res += x % 10;
                x /= 10;
            }
            return res;
        }
    }
}
