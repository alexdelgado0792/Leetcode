using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems.PlusOne
{
    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            var result = new Stack<int>();
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var sum = digits[i] + carry;
                carry = sum / 10;

                result.Push(sum % 10);
            }

            if (carry > 0)
            {
                result.Push(carry);
            }

            return result.ToArray();
        }

    }
}
