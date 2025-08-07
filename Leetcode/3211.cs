namespace Leetcode
{
    class _3211
    {
        public IList<string> ValidStrings(int n)
        {
            var res = new List<string>();
            Backtrack(res, n, "0", 1);
            Backtrack(res, n, "1", 1);
            return res;
        }

        private void Backtrack(IList<string> res, int n, string currStr, int next)
        {
            if (currStr.Length == n)
            {
                res.Add(currStr);
                return;
            }

            if (next == 1)
            {
                Backtrack(res, n, currStr + "1", 1);
                Backtrack(res, n, currStr + "0", 0);
            }
            else
            {
                Backtrack(res, n, currStr + "1", 1);
            }
        }
    }
}
