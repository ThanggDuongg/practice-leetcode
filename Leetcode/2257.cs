namespace Leetcode
{
    internal class _2257
    {
        public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            var visited = new HashSet<(int, int)>();
            var wallSet = new HashSet<(int, int)>();
            var guardSet = new HashSet<(int, int)>();
            foreach (var wall in walls)
            {
                wallSet.Add((wall[0], wall[1]));
            }
            foreach (var guard in guards)
            {
                guardSet.Add((guard[0], guard[1]));
            }
            foreach (var guard in guardSet)
            {
                var (x, y) = guard;
                // Up
                for (int i = x - 1; i >= 0; i--)
                {
                    if (wallSet.Contains((i, y)) || guardSet.Contains((i, y)))
                    {
                        break;
                    }

                    visited.Add((i, y));
                }
                // Down
                for (int i = x + 1; i < m; i++)
                {
                    if (wallSet.Contains((i, y)) || guardSet.Contains((i, y)))
                    {
                        break;
                    }

                    visited.Add((i, y));
                }
                // Left
                for (int j = y - 1; j >= 0; j--)
                {
                    if (wallSet.Contains((x, j)) || guardSet.Contains((x, j)))
                    {
                        break;
                    }

                    visited.Add((x, j));
                }
                // Right
                for (int j = y + 1; j < n; j++)
                {
                    if (wallSet.Contains((x, j)) || guardSet.Contains((x, j)))
                    {
                        break;
                    }

                    visited.Add((x, j));
                }
            }

            return m * n - visited.Count - guards.Length - walls.Length;
        }
    }
}
