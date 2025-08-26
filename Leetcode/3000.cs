namespace Leetcode
{
  internal class _3000
  {
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
      int res = 0,
        maxDiagonal = 0;

      foreach (var dim in dimensions)
      {
        int diagonal = dim[0] * dim[0] + dim[1] * dim[1];
        if (diagonal > maxDiagonal)
        {
          maxDiagonal = diagonal;
          res = dim[0] * dim[1];
        }
        else if (diagonal == maxDiagonal)
        {
          res = Math.Max(res, dim[0] * dim[1]);
        }
      }

      return res;
    }
  }
}
