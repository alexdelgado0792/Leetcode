using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.Valid_Parentheses;

namespace LeedCodeTest
{
    public class ValidParentheses
    {
        [Theory]
        [InlineData("{()}", true)]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{([{{()}}])}", true)]
        [InlineData("", true)]
        [InlineData("){", false)]
        public void TwoSumPass(string input, bool result)
        {
            Assert.Equal(result, Solution.IsValid(input));
        }
    }
}
