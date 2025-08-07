namespace Leetcode
{
    class _1353
    {
        public int MaxEvents(int[][] events)
        {
            Array.Sort(events, (x, y) => x[0].CompareTo(y[0]));

            var visited = new bool[100001];
            var res = 0;
            foreach (var evt in events)
            {
                for (int i = evt[0]; i <= evt[1]; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        res++;
                        break;
                    }
                }
            }

            return res;
        }
    }
}
