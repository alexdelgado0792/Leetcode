using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.Implement_strStr;

namespace LeedCodeTest
{
    public class StrStr
    {
        [Theory]
        [InlineData("hello", "ll")]
        [InlineData("aaaaa", "bba")]
        [InlineData("aaaaa", "aaaaa")]
        public void Pass(string haystack, string needle)
        {
            //Solution.StrStr(haystack,needle);
        }
    }
}
