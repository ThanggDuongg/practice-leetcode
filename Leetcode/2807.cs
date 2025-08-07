namespace Leetcode
{
    class _2807
    {
        private int GCD(int x, int y)
        {
            while (y != 0)
            {
                x %= y;
                (x, y) = (y, x);
            }
            return x;
        }

        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode cur = head;

            while (cur is not null && cur.next is not null)
            {
                cur.next = new ListNode(GCD(cur.val, cur.next.val), cur.next);
                cur = cur.next.next;
            }

            return head;
        }
    }
}
