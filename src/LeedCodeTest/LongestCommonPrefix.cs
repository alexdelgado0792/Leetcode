using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.LongestCommonPrefix;

namespace LeedCodeTest
{
    public class LongestCommonPrefix
    {
        [Theory]
        [InlineData(new object[] { new string[] { "flower", "flow", "flight" }, "fl" })]
        [InlineData(new object[] { new string[] { "dog", "racecar", "car" }, "" })]
        public void Pass(string[] phrases, string result)
        {
            Assert.Equal(result, Solution.LongestCommonPrefix(phrases));
        }
    }
}
