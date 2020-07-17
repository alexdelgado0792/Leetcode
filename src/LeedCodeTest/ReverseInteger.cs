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
        [InlineData(123,321)] 
        [InlineData(-123,-321)] 
        [InlineData(120,21)]
        [InlineData(int.MaxValue, 7463847412)]
        [InlineData(int.MinValue, -8463847412)]
        public void Pass(int number, int result)
        {
            Assert.Equal(result, Solution.Reverse(number));
        }
    }
}
