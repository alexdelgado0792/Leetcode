using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.ReverseInteger;
namespace LeedCodeTest
{
    public class ReverseInteger
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        public void Pass(int number, long result)
        {
            Assert.Equal(result, Solution.Reverse(number));
        }
    }
}
