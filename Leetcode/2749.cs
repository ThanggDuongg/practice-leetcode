namespace Leetcode
{
    internal class _2749
    {
        public int MakeTheIntegerZero(int num1, int num2)
        {
            for (int i = 1; i <= 60; i++)
            {
                long target = num1 - (long)i * num2;
                if (target < 0)
                {
                    continue;
                }

                if (target >= i && CountBits(target) <= i)
                {
                    return i;
                }
            }
            return -1;
        }

        private int CountBits(long n)
        {
            var count = 0;
            while (n != 0)
            {
                count += (int)n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
