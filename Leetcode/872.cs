namespace Leetcode
{
    public class _872
    {
        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            Stack<TreeNode> stack1 = new(),
                stack2 = new();
            stack1.Push(root1);
            stack2.Push(root2);
            List<int> res1 = [],
                res2 = [];

            while (stack1.Count > 0)
            {
                var cur = stack1.Pop();
                if (cur.left is null && cur.right is null)
                {
                    res1.Add(cur.val);
                    continue;
                }

                if (cur.left is not null)
                {
                    stack1.Push(cur.left);
                }
                if (cur.right is not null)
                {
                    stack1.Push(cur.right);
                }
            }

            while (stack2.Count > 0)
            {
                var cur = stack2.Pop();
                if (cur.left is null && cur.right is null)
                {
                    res2.Add(cur.val);
                    continue;
                }

                if (cur.left is not null)
                {
                    stack2.Push(cur.left);
                }
                if (cur.right is not null)
                {
                    stack2.Push(cur.right);
                }
            }

            return res1.SequenceEqual(res2);
        }
    }
}
