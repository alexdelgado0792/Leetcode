using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Problems.PalindromeNumber
{
    public static class Solution
    {
        public static bool IsPalindrome(int x)
        {
            return NumberApproach(x);
        }


        private static bool StringApproach(int x)
        {

            if (x < 0) return false;
            long reversedNumber = long.Parse(new string(x.ToString().Reverse().ToArray()));

            return x == reversedNumber;
        }


        private static bool NumberApproach(int x)
        {
            if (x < 0) return false;

            int original = x;
            int reversed = 0;
            while (x != 0)
            {
                int remainder = x % 10;
                reversed = (reversed * 10) + remainder;

                x = x / 10;
            }

            return original == reversed;
        }
    }
}
