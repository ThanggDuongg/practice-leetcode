namespace Leetcode
{
    class _155
    {
        private readonly IList<(int val, int min)> Stack;

        public _155()
        {
            Stack = [];
        }

        public void Push(int val)
        {
            if (Stack.Count == 0)
            {
                Stack.Add((val, 0));
            }
            else
            {
                Stack.Add((val, Math.Min(Stack[Stack.Count - 1].min, val)));
            }
        }

        public void Pop()
        {
            Stack.RemoveAt(Stack.Count - 1);
        }

        public int Top()
        {
            return Stack[Stack.Count - 1].val;
        }

        public int GetMin()
        {
            return Stack[Stack.Count - 1].min;
        }
    }
}
