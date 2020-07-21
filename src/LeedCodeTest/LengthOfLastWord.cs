using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.LenghtLastWord;

namespace LeedCodeTest
{
    public class LengthOfLastWord
    {
        [Theory]
        [InlineData("HelloWorld")]
        [InlineData("Hello World")]
        [InlineData("a ")]
        [InlineData("")]
        [InlineData("One of the things ")]
        public void Pass(string s)
        {
            Assert.Equal(5, Solution.LengthOfLastWord(s));
        }
    }
}
