namespace Leetcode
{
    internal class _1518
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            if (numBottles < numExchange)
            {
                return numBottles;
            }

            int emptyBottles = numBottles,
                res = numBottles;

            while (emptyBottles >= numExchange)
            {
                var newFullBottles = emptyBottles / numExchange;
                res += newFullBottles;
                var newEmptyBottles = newFullBottles;
                emptyBottles = (emptyBottles % numExchange) + newEmptyBottles;
            }

            return res;
        }
    }
}
