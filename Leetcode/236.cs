namespace Leetcode
{
    class _236
    {
        public record Track(TreeNode node, List<TreeNode> list);

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var stack = new Stack<Track>();
            stack.Push(new Track(root, new List<TreeNode>()));

            Track? foundP = null,
                foundQ = null;

            while (stack.Count > 0)
            {
                var (node, path) = stack.Pop();
                var newPath = new List<TreeNode>(path) { node };

                if (node == p)
                    foundP = new(node, newPath);
                if (node == q)
                    foundQ = new(node, newPath);

                if (foundP is not null && foundQ is not null)
                    break;

                if (node.left is not null)
                    stack.Push(new Track(node.left, newPath));
                if (node.right is not null)
                    stack.Push(new Track(node.right, newPath));
            }

            if (foundP is null || foundQ is null)
                return root;

            var pathP = foundP.list;
            var pathQ = foundQ.list;
            int minLength = Math.Min(pathP.Count, pathQ.Count);
            TreeNode? lca = root;

            for (int i = 0; i < minLength; i++)
            {
                if (pathP[i] == pathQ[i])
                    lca = pathP[i];
                else
                    break;
            }

            return lca!;
        }
    }
}
