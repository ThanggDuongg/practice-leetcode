namespace Leetcode
{
    internal class _84
    {
        public int te(int[] heights)
        {
            int res = 0;
            var stack = new Stack<int>();

            for (int i = 0; i < heights.Length; i++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
                {
                    int h = heights[stack.Pop()];
                    int w = stack.Count == 0 ? i : i - stack.Peek() - 1;
                    res = Math.Max(res, h * w);
                }
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                int h = heights[stack.Pop()];
                int w = stack.Count == 0 ? heights.Length : heights.Length - stack.Peek() - 1;
                res = Math.Max(res, h * w);
            }

            return res;
        }
    }
}
