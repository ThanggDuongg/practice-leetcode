namespace Leetcode
{
    internal class _342
    {
        public bool IsPowerOfFour(int n)
        {
            if (n == 0)
            {
                return false;
            }

            return (n & n - 1) == 0 && (n - 1) % 3 == 0;
        }
    }
}
