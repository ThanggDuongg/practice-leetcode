namespace Leetcode
{
    internal class _1372
    {
        public int LongestZigZag(TreeNode root)
        {
            if (root is null || (root.right is null && root.left is null))
                return 0;
            var stack = new Stack<(TreeNode node, int count, bool isRight)>();
            if (root.right is not null)
            {
                stack.Push((root.right, 1, true));
            }
            if (root.left is not null)
            {
                stack.Push((root.left, 1, false));
            }
            var res = 0;

            while (stack.Count > 0)
            {
                var (node, count, isRight) = stack.Pop();
                res = Math.Max(res, count);

                if (node.left is not null)
                {
                    var nextCount = isRight ? count + 1 : 1;
                    stack.Push((node.left, nextCount, false));
                }

                if (node.right is not null)
                {
                    var nextCount = !isRight ? count + 1 : 1;
                    stack.Push((node.right, nextCount, true));
                }
            }

            return res;
        }
    }
}
