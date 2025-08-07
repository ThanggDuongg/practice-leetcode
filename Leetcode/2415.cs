namespace Leetcode
{
    class _2415
    {
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            DFS(root.left, root.right, 1);
            return root;
        }

        private void DFS(TreeNode? left, TreeNode? right, int level)
        {
            if (left is null || right is null)
            {
                return;
            }

            if (level % 2 != 0)
            {
                (left.val, right.val) = (right.val, left.val);
            }
            DFS(left.left, right.right, level + 1);
            DFS(right.left, left.right, level + 1);
        }
    }
}
