namespace Leetcode
{
    internal class _19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(-1) { next = head };

            ListNode fast = dummy,
                slow = dummy;
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;
            return dummy.next;
        }
    }
}
