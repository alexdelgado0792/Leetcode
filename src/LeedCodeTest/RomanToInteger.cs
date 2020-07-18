using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.RomanToInteger;

namespace LeedCodeTest
{
    public class RomanToInteger
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Pass(string RomanNumber, long result)
        {
            Assert.Equal(result, Solution.RomanToInt(RomanNumber));
        }
    }
}
