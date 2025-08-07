namespace Leetcode
{
    internal class _79
    {
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || string.IsNullOrEmpty(word))
            {
                return false;
            }

            int m = board.Length,
                n = board[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (DFS(board, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool DFS(char[][] board, string word, int x, int y, int index)
        {
            if (index == word.Length)
            {
                return true;
            }

            if (
                x < 0
                || x >= board.Length
                || y < 0
                || y >= board[0].Length
                || board[x][y] != word[index]
            )
            {
                return false;
            }

            char temp = board[x][y];
            board[x][y] = '#';

            bool found =
                DFS(board, word, x + 1, y, index + 1)
                || DFS(board, word, x - 1, y, index + 1)
                || DFS(board, word, x, y + 1, index + 1)
                || DFS(board, word, x, y - 1, index + 1);

            board[x][y] = temp;
            return found;
        }
    }
}
