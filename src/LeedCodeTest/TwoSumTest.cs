﻿using Problems.TwoSum;
using Xunit;

namespace LeedCodeTest
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new object[] { new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } })]
        [InlineData(new object[] { new int[] { 2, 5, 11, 15 }, 9, new int[] { 0, 0 } })]
        public void TwoSum(int[] nums, int target, int[] result)
        {
            Assert.Equal(result, Solution.TwoSum(nums, target));
        }
    }
}
