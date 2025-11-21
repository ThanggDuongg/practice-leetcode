namespace Leetcode
{
    internal class _417
    {
        private readonly HashSet<(int, int)> Dir = [(1, 0), (-1, 0), (0, 1), (0, -1)];

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var pacific = new bool[heights.Length, heights[0].Length];
            var atlantic = new bool[heights.Length, heights[0].Length];
            var queuePacific = new Queue<(int, int)>();
            var queueAtlantic = new Queue<(int, int)>();

            int m = heights.Length,
                n = heights[0].Length;

            for (int i = 0; i < m; i++)
            {
                pacific[i, 0] = true;
                atlantic[i, n - 1] = true;
                queuePacific.Enqueue((i, 0));
                queueAtlantic.Enqueue((i, n - 1));
            }
            for (int j = 0; j < n; j++)
            {
                pacific[0, j] = true;
                atlantic[m - 1, j] = true;
                queuePacific.Enqueue((0, j));
                queueAtlantic.Enqueue((m - 1, j));
            }

            Bfs(pacific, queuePacific, m, n, heights);
            Bfs(atlantic, queueAtlantic, m, n, heights);

            var res = new List<IList<int>>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pacific[i, j] && atlantic[i, j])
                    {
                        res.Add([i, j]);
                    }
                }
            }
            return res;
        }

        private void Bfs(bool[,] ocean, Queue<(int, int)> queue, int m, int n, int[][] heights)
        {
            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();
                foreach (var (dx, dy) in Dir)
                {
                    var nx = x + dx;
                    var ny = y + dy;
                    if (
                        nx >= 0
                        && nx < m
                        && ny >= 0
                        && ny < n
                        && !ocean[nx, ny]
                        && heights[nx][ny] >= heights[x][y]
                    )
                    {
                        ocean[nx, ny] = true;
                        queue.Enqueue((nx, ny));
                    }
                }
            }
        }
    }
}
