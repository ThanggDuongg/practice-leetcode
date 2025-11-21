namespace Leetcode
{
    internal class _2503
    {
        public readonly struct Cell(int x, int y, int value)
        {
            public readonly int X = x,
                Y = y,
                Value = value;
        }

        public int[] MaxPoints(int[][] grid, int[] queries)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int q = queries.Length;

            var res = new int[q];
            var indexedQueries = new (int value, int index)[q];
            for (int i = 0; i < q; i++)
            {
                indexedQueries[i] = (queries[i], i);
            }

            Array.Sort(indexedQueries, (a, b) => a.value.CompareTo(b.value));

            var queue = new PriorityQueue<Cell, int>();
            var visited = new bool[m, n];
            queue.Enqueue(new Cell(0, 0, grid[0][0]), grid[0][0]);
            visited[0, 0] = true;

            int count = 0;
            Span<int> dirs = [0, 1, 0, -1, 0];

            foreach (var (queryValue, idx) in indexedQueries)
            {
                while (queue.TryPeek(out var top, out _) && top.Value < queryValue)
                {
                    var cell = queue.Dequeue();
                    var (x, y) = (cell.X, cell.Y);
                    count++;

                    for (int k = 0; k < 4; k++)
                    {
                        int nx = x + dirs[k];
                        int ny = y + dirs[k + 1];
                        if (nx >= 0 && nx < m && ny >= 0 && ny < n && !visited[nx, ny])
                        {
                            visited[nx, ny] = true;
                            queue.Enqueue(new Cell(nx, ny, grid[nx][ny]), grid[nx][ny]);
                        }
                    }
                }
                res[idx] = count;
            }

            return res;
        }
    }
}
