namespace Leetcode
{
    class _374
    {
        public int GuessNumber(int n)
        {
            int start = 0,
                end = n;

            while (start <= end)
            {
                int mid = (end - start) / 2;
                int result = guess(mid);

                if (result == 0)
                    return mid;
                else if (result < 0)
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return -1;
        }

        private int guess(object num)
        {
            throw new NotImplementedException();
        }
    }
}
