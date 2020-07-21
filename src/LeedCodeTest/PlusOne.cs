using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.PlusOne;

namespace LeedCodeTest
{
    public class PlusOne
    {
        [Theory]
        [InlineData(new object[] { new int[] { 3, 9, 9, 9 } })]
        [InlineData(new object[] { new int[] { 9, 9, 9 } })]
        [InlineData(new object[] { new int[] { 0 } })]
        [InlineData(new object[] { new int[] { 2,5 } })]
        [InlineData(new object[] { new int[] { 4, 3, 2, 1 } })]
        public void Pass(int[] num)
        {
           Solution.PlusOne(num);
        }
    }
}
