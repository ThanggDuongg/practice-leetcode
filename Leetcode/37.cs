namespace Leetcode
{
  internal class _37
  {
    public void SolveSudoku(char[][] board)
    {
      Backtrack(board);
    }

    private bool Backtrack(char[][] board)
    {
      for (var i = 0; i < 9; i++)
      {
        for (var j = 0; j < 9; j++)
        {
          if (board[i][j] == '.')
          {
            for (var c = '1'; c <= '9'; c++)
            {
              if (IsValid(i, j, board, c))
              {
                board[i][j] = c;
                if (Backtrack(board))
                {
                  return true;
                }
                board[i][j] = '.';
              }
            }
            return false;
          }
        }
      }
      return true;
    }

    private bool IsValid(int x, int y, char[][] board, char c)
    {
      for (int i = 0; i < 9; i++)
      {
        if (board[i][y] == c)
        {
          return false;
        }

        if (board[x][i] == c)
        {
          return false;
        }

        if (board[(x / 3) * 3 + i / 3][(y / 3) * 3 + i % 3] == c)
        {
          return false;
        }
      }
      return true;
    }
  }
}
