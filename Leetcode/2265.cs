namespace Leetcode
{
    class _2265
    {
        public int AverageOfSubtree(TreeNode root)
        {
            int count = 0,
                res = 0;
            Sum(root, ref count, ref res);
            return res;
        }

        private int Sum(TreeNode node, ref int count, ref int res)
        {
            int countLeft = 0,
                countRight = 0,
                currentSumLeft = 0,
                currentSumRight = 0;
            if (node.left is not null)
            {
                currentSumLeft = Sum(node.left, ref countLeft, ref res);
            }

            if (node.right is not null)
            {
                currentSumRight = Sum(node.right, ref countRight, ref res);
            }

            var currentSum = node.val + currentSumLeft + currentSumRight;
            count = 1 + countLeft + countRight;

            if (currentSum / count == node.val)
            {
                res++;
            }

            return currentSum;
        }
    }
}
