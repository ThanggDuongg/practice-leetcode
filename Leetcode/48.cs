namespace Leetcode
{
    class _48
    {
        public void Rotate(int[][] matrix)
        {
            var len = matrix.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len / 2; j++)
                {
                    (matrix[i][j], matrix[i][len - j - 1]) = (matrix[i][len - j - 1], matrix[i][j]);
                }
            }
        }
    }
}
