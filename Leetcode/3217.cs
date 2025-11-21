namespace Leetcode
{
    internal class _3217
    {
        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            var set = nums.ToHashSet();
            var res = new ListNode(0);
            var current = res;

            while (head != null)
            {
                if (!set.Contains(head.val))
                {
                    current.next = new ListNode(head.val);
                    current = current.next;
                }
                head = head.next;
            }
            return res.next;
        }
    }
}
