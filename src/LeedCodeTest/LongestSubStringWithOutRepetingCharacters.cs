using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.LongestSubStringWithOutRepetingCharacters;

namespace LeedCodeTest
{
    public class LongestSubStringWithOutRepetingCharacters
    {
        [Theory]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LongestSubStringPass(string input, int result)
        {
            Assert.Equal(result, Solution.LengthOfLongestSubstring(input));
        }
    }
}
