namespace Leetcode
{
    internal class _1716
    {
        public int TotalMoney(int n)
        {
            var debt = n % 7;
            var numberOfDay = n / 7;

            var res =
                28 * numberOfDay
                + (7 * numberOfDay * (numberOfDay - 1) / 2)
                + (debt * (1 + debt)) / 2
                + debt * numberOfDay;
            return res;
            return (n / 7) * 28 + (n % 7) * (n % 7 + 1) / 2 + (n / 7) * (n % 7);
        }
    }
}
