namespace Leetcode
{
    internal class _1578
    {
        public int MinCost(string colors, int[] neededTime)
        {
            int res = 0;
            for (int i = 1; i < colors.Length; i++)
            {
                if (colors[i] == colors[i - 1])
                {
                    if (neededTime[i] < neededTime[i - 1])
                    {
                        res += neededTime[i];
                        neededTime[i - 1] = neededTime[i];
                    }
                    else
                    {
                        res += neededTime[i - 1];
                        neededTime[i] = neededTime[i - 1];
                    }
                }
            }

            return res;
        }
    }
}
