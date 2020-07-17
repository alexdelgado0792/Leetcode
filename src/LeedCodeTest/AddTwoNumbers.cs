using Problems.AddTwoNumbers;
using Xunit;

namespace LeedCodeTest
{
    public class AddTwoNumbers
    {
        [Fact]
        public void AddTwoNumbersPass()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var r = new ListNode(7, new ListNode(0, new ListNode(8)));
            var solve = Solution.AddTwoNumbers(l1, l2);

            while (r != null)
            {
                Assert.Equal(r.val, solve.val); ;
                r = r.next;
                solve = solve.next;
            }
        }

    }
}
