namespace Leetcode
{
    internal class _2197
    {
        public IList<int> ReplaceNonCoprimes(int[] nums)
        {
            var res = new List<int>();

            foreach (var num in nums)
            {
                res.Add(num);

                while (res.Count >= 2)
                {
                    var first = res[^1];
                    var second = res[^2];

                    if (GCD(first, second) > 1)
                    {
                        res.RemoveAt(res.Count - 1);
                        res.RemoveAt(res.Count - 1);
                        var lcm = ((long)first * second) / GCD(first, second);
                        res.Add((int)lcm);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return res;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }
            return a;
        }
    }
}
