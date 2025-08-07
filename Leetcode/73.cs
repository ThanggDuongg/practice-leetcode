namespace Leetcode
{
    class _73
    {
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length,
                n = matrix[0].Length;
            bool isFirstRowZero = false,
                isFirstColumnZero = false;

            for (int i = 0; i < m; i++)
            {
                if (matrix[i][0] == 0)
                {
                    isFirstColumnZero = true;
                    break;
                }
            }

            for (int j = 0; j < n; j++)
            {
                if (matrix[0][j] == 0)
                {
                    isFirstRowZero = true;
                    break;
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (isFirstRowZero)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            if (isFirstColumnZero)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}
