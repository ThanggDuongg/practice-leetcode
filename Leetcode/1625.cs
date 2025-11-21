namespace Leetcode
{
    internal class _1625
    {
        public string FindLexSmallestString(string s, int a, int b)
        {
            var visited = new HashSet<string>() { s };
            var queue = new Queue<string>();
            queue.Enqueue(s);
            var res = s;

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();

                if (string.Compare(curr, res) < 0)
                {
                    res = curr;
                }

                var calculatedChar = curr.ToCharArray();
                for (int i = 1; i < calculatedChar.Length; i += 2)
                {
                    calculatedChar[i] = (char)((((calculatedChar[i] - '0') + a) % 10) + '0');
                }
                var calculatedString = new string(calculatedChar);
                if (!visited.Contains(calculatedString))
                {
                    queue.Enqueue(calculatedString);
                    visited.Add(calculatedString);
                }

                var rotatedString = curr[^b..] + curr[..^b];
                if (!visited.Contains(rotatedString))
                {
                    queue.Enqueue(rotatedString);
                    visited.Add(rotatedString);
                }
            }

            return res;
        }
    }
}
