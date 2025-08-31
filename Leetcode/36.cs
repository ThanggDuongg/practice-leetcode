namespace Leetcode
{
  internal class _36
  {
    public bool IsValidSudoku(char[][] board)
    {
      var rows = new bool[9, 9];
      var cols = new bool[9, 9];
      var boxes = new bool[9, 9];

      for (int i = 0; i < 9; i++)
      {
        for (int j = 0; j < 9; j++)
        {
          if (board[i][j] == '.')
          {
            continue;
          }

          var num = board[i][j] - '1';
          var boxIndex = (i / 3) * 3 + j / 3;
          if (rows[i, num] || cols[j, num] || boxes[boxIndex, num])
          {
            return false;
          }
          rows[i, num] = true;
          cols[j, num] = true;
          boxes[boxIndex, num] = true;
        }
      }

      return true;
    }
  }
}
