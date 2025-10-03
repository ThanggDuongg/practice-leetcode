namespace Leetcode
{
    internal class _407
    {
        public int TrapRainWater(int[][] heightMap)
        {
            var queue = new PriorityQueue<(int h, int x, int y), int>();
            int m = heightMap.Length,
                n = heightMap[0].Length;
            var visited = new bool[m, n];

            for (int i = 0; i < m; i++)
            {
                queue.Enqueue((heightMap[i][0], i, 0), heightMap[i][0]);
                queue.Enqueue((heightMap[i][n - 1], i, n - 1), heightMap[i][n - 1]);
                visited[i, 0] = true;
                visited[i, n - 1] = true;
            }

            for (int j = 1; j < n - 1; j++)
            {
                queue.Enqueue((heightMap[0][j], 0, j), heightMap[0][j]);
                queue.Enqueue((heightMap[m - 1][j], m - 1, j), heightMap[m - 1][j]);
                visited[0, j] = true;
                visited[m - 1, j] = true;
            }

            var dir = new HashSet<(int, int)> { (1, 0), (-1, 0), (0, 1), (0, -1) };
            var res = 0;
            while (queue.Count > 0)
            {
                var (h, x, y) = queue.Dequeue();
                foreach (var (dx, dy) in dir)
                {
                    var nx = x + dx;
                    var ny = y + dy;
                    if (nx > 0 && nx < m - 1 && ny > 0 && ny < n - 1 && !visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        if (heightMap[nx][ny] < h)
                        {
                            res += h - heightMap[nx][ny];
                            heightMap[nx][ny] = h;
                        }
                        queue.Enqueue((heightMap[nx][ny], nx, ny), heightMap[nx][ny]);
                    }
                }
            }

            return res;
        }
    }
}
