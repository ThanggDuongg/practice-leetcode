namespace Leetcode
{
    internal class _2300
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            int m = spells.Length,
                n = potions.Length;
            var res = new int[m];

            Array.Sort(potions);

            for (int i = 0; i < m; i++)
            {
                int left = 0,
                    right = n - 1;

                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    long value = (long)spells[i] * potions[mid];
                    if (value >= success)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                res[i] = n - left;
            }

            return res;
        }
    }
}
