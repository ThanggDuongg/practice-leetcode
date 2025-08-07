namespace Leetcode
{
    class _1448
    {
        public int GoodNodes(TreeNode root)
        {
            if (root is null)
                return 0;
            if (root.left is null && root.right is null)
                return 1;

            var tracking = new Stack<(TreeNode, int)>();
            tracking.Push((root, root.val));
            var res = 1;

            while (tracking.Count > 0)
            {
                var node = tracking.Pop();
                if (node.Item1.left is not null)
                {
                    if (node.Item1.left.val >= node.Item2)
                    {
                        res++;
                    }
                    tracking.Push((node.Item1.left, Math.Max(node.Item2, node.Item1.left.val)));
                }
                if (node.Item1.right is not null)
                {
                    if (node.Item1.right.val >= node.Item2)
                    {
                        res++;
                    }
                    tracking.Push((node.Item1.right, Math.Max(node.Item2, node.Item1.right.val)));
                }
            }

            return res;
        }
    }
}
