using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Problems.RemoveDuplicatesfromSortedArray;

namespace LeedCodeTest
{
    public class RemoveDuplicates
    {
        [Theory]
        [InlineData(new object[] { new int[] { 1, 1, 2 }, 2 })]
        public void TwoSumPass(int[] input, int result)
        {
            Assert.Equal(result, Solution.RemoveDuplicates(input));
        }
    }
}
