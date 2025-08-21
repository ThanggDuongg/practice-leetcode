namespace Leetcode
{
    internal class _141
    {
        public bool HasCycle(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return false;
            }

            var visisted = new HashSet<ListNode>();
            while (head != null)
            {
                if (visisted.Contains(head))
                {
                    return true;
                }
                visisted.Add(head);
                head = head.next;
            }
            return false;
        }
    }
}
