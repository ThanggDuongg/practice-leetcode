namespace Leetcode
{
  internal class _498
  {
    public int[] FindDiagonalOrder(int[][] mat)
    {
      int m = mat.Length,
        n = mat[0].Length,
        totalLen = m * n;
      var res = new int[totalLen];

      int curX = 0,
        curY = 0,
        i = 0;
      var isUp = true;
      while (i < totalLen)
      {
        res[i++] = mat[curX][curY];
        if (!isUp)
        {
          if (curX == m - 1)
          {
            curY++;
            isUp = true;
          }
          else if (curY == 0)
          {
            curX++;
            isUp = true;
          }
          else
          {
            curY--;
            curX++;
          }
        }
        else
        {
          if (curY == n - 1)
          {
            curX++;
            isUp = false;
          }
          else if (curX == 0)
          {
            curY++;
            isUp = false;
          }
          else
          {
            curY++;
            curX--;
          }
        }
      }

      return res;
    }
  }
}
