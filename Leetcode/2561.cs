namespace Leetcode
{
    class _2561
    {
        public long MinCost(int[] basket1, int[] basket2)
        {
            var freq1 = new Dictionary<int, int>();
            var freq2 = new Dictionary<int, int>();

            foreach (var item in basket1)
            {
                freq1[item] = freq1.GetValueOrDefault(item, 0) + 1;
            }

            foreach (var item in basket2)
            {
                freq2[item] = freq2.GetValueOrDefault(item, 0) + 1;
            }

            var swap1 = new List<int>();
            var swap2 = new List<int>();
            var allKeys = new HashSet<int>(freq1.Keys);
            allKeys.UnionWith(freq2.Keys);
            foreach (var key in allKeys)
            {
                int count1 = freq1.GetValueOrDefault(key, 0);
                int count2 = freq2.GetValueOrDefault(key, 0);

                int total = count1 + count2;
                if (total % 2 != 0)
                {
                    return -1;
                }

                int diff = count1 - count2;
                if (diff > 0)
                {
                    for (int i = 0; i < diff / 2; i++)
                    {
                        swap1.Add(key);
                    }
                }
                else if (diff < 0)
                {
                    for (int i = 0; i < -diff / 2; i++)
                    {
                        swap2.Add(key);
                    }
                }
            }

            swap1.Sort();
            swap2.Sort();
            swap2.Reverse();

            var minElement = basket1.Concat(basket2).Min();
            var res = 0;

            for (int i = 0; i < swap1.Count; i++)
            {
                var directSwap = Math.Min(swap1[i], swap2[i]);
                res += Math.Min(directSwap, 2 * minElement);
            }

            return res;
        }
    }
}
