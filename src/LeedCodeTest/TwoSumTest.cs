using Problems.TwoSum;
using System;
using Xunit;

namespace LeedCodeTest
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new object[] { new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } })]
        public void TwoSumPass(int[] nums, int target, int[] result)
        {
            Assert.Equal(result, Solution.TwoSum(nums, target));
        }

        [Theory]
        [InlineData(new object[] { new int[] { 2, 5, 11, 15 }, 9})]
        public void TwoSumNotPass(int[] nums, int target)
        {
            Assert.Throws<Exception>(() => Solution.TwoSum(nums, target));
        }
    }
}
