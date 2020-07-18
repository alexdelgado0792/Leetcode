using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeedCodeTest
{
    public class PalindromeNumber
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(0, true)]
        [InlineData(10, false)]
        public void IsPalindromePass(int num, bool result)
        {
            Assert.Equal(result, Problems.PalindromeNumber.Solution.IsPalindrome(num));
        }
    }
}
