namespace Leetcode
{
    public class Spreadsheet
    {
        private readonly int[][] Table;

        public Spreadsheet(int rows)
        {
            Table = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Table[i] = new int[26];
            }
        }

        public void SetCell(string cell, int value)
        {
            var col = cell[0] - 'A';
            var row = int.Parse(cell[1..]) - 1;
            Table[row][col] = value;
        }

        public void ResetCell(string cell)
        {
            var col = cell[0] - 'A';
            var row = int.Parse(cell[1..]) - 1;
            Table[row][col] = 0;
        }

        public int GetValue(string formula)
        {
            var argues = formula[1..].Split("+");

            if (!int.TryParse(argues[0], out var argue1))
            {
                var col = argues[0][0] - 'A';
                var row = int.Parse(argues[0][1..]) - 1;
                argue1 = Table[row][col];
            }

            if (!int.TryParse(argues[1], out var argue2))
            {
                var col = argues[1][0] - 'A';
                var row = int.Parse(argues[1][1..]) - 1;
                argue2 = Table[row][col];
            }

            return argue1 + argue2;
        }
    }
}
