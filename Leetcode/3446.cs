namespace Leetcode
{
  internal class _3446
  {
    public int[][] SortMatrix(int[][] grid)
    {
      var len = grid.Length;
      var start = len - 2;

      while (start >= 0)
      {
        var list = new List<int>();
        int i = start,
          j = 0;
        while (i < len)
        {
          list.Add(grid[i++][j++]);
        }
        list.Sort((x, y) => y.CompareTo(x));
        i = start;
        j = 0;
        while (i < len)
        {
          grid[i++][j] = list[j++];
        }
        start--;
      }

      start = 1;
      while (start < len)
      {
        var list = new List<int>();
        int i = 0,
          j = start;
        while (j < len)
        {
          list.Add(grid[i++][j++]);
        }
        list.Sort((x, y) => x.CompareTo(y));
        i = 0;
        j = start;
        while (j < len)
        {
          grid[i][j++] = list[i++];
        }
        start++;
      }

      return grid;
    }
  }
}
