namespace Leetcode
{
    class _1423
    {
        //public int MaxScore(int[] cardPoints, int k)
        //{
        //    int res = 0,
        //        sum = 0,
        //        start = 0;
        //    foreach (var point in cardPoints)
        //    {
        //        sum += point;
        //    }

        //    while (start <= k)
        //    {
        //        int end = cardPoints.Length - k + start,
        //            currentSum = 0;
        //        for (int i = start; i < end; i++)
        //        {
        //            currentSum += cardPoints[i];
        //        }
        //        res = Math.Max(res, sum - currentSum);
        //        start++;
        //    }

        //    return res;
        //}

        public int MaxScore(int[] cardPoints, int k)
        {
            int res = 0,
                sum = 0,
                start = 0,
                curSum = 0;
            foreach (var point in cardPoints)
            {
                sum += point;
            }

            if (k >= cardPoints.Length)
            {
                return sum;
            }

            for (int i = 0; i < cardPoints.Length; i++)
            {
                curSum += cardPoints[i];

                if (i - start + 1 == cardPoints.Length - k)
                {
                    res = Math.Max(res, sum - curSum);
                    curSum -= cardPoints[start];
                    start++;
                }
            }

            return res;
        }
    }
}
