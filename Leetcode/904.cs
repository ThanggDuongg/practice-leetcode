namespace Leetcode
{
    class _904
    {
        public int TotalFruit(int[] fruits)
        {
            var dict = new Dictionary<int, int>();
            int start = 0,
                res = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                dict[fruits[i]] = dict.GetValueOrDefault(fruits[i], 0) + 1;

                while (dict.Count > 2)
                {
                    dict[fruits[start]]--;
                    if (dict[fruits[start]] == 0)
                    {
                        dict.Remove(fruits[start]);
                    }
                    start++;
                }

                res = Math.Max(res, i - start + 1);
            }

            return res;
        }
    }
}
