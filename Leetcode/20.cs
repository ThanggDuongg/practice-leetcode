namespace Leetcode
{
    class _20
    {
        public bool IsValid(string s)
        {
            var mapping = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' },
            };

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (!mapping.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || stack.Pop() != mapping[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
