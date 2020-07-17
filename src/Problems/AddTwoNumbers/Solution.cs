namespace Problems.AddTwoNumbers
{
    public static class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l3 = new ListNode(0);
            ListNode current = l3;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int n1 = (l1 != null) ? l1.val : 0;
                int n2 = (l2 != null) ? l2.val : 0;
                int sum = n1 + n2 + carry;

                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return l3.next;
        }
    }
}
