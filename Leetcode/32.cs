namespace Leetcode
{
    internal class _32
    {
        public int LongestValidParentheses(string s)
        {
            var res = 0;
            var stack = new Stack<int>(-1);
            stack.Push(-1);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        res = Math.Max(res, i - stack.Peek());
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }

            return res;
        }
    }
}
