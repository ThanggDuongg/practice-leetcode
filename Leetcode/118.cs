namespace Leetcode
{
    class _118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            if (numRows == 1)
            {
                result.Add([1]);
                return result;
            }
            else if (numRows == 2)
            {
                result.AddRange(
                    [
                        [1],
                        [1, 1],
                    ]
                );
                return result;
            }

            result.AddRange(
                [
                    [1],
                    [1, 1],
                ]
            );
            for (int i = 3; i <= numRows; i++)
            {
                var arr = new List<int>() { 1 };
                for (int j = 1; j <= i - 2; j++)
                {
                    var sum = result[i - 2][j - 1] + result[i - 2][j];
                    arr.Add(sum);
                }
                arr.Add(1);
                result.Add(arr);
            }

            return result;
        }
    }
}
