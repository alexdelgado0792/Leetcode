using Problems.MediumOfTwoSortedArray;
using Xunit;

namespace LeedCodeTest
{
    public class FindMedianSortedArrays
    {
        [Theory]
        [InlineData(new object[] { new int[] { 1, 3 }, new int[] { 2 }, 2.0 })]
        [InlineData(new object[] { new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5 })]
        [InlineData(new object[] { new int[] { 40000, 29000, 35500, 31000, 43000 }, new int[] { 30000, 27000, 32000 }, 31500 })]
        [InlineData(new object[] { new int[] { 3 }, new int[] { -2,-1}, -1.0 })] // caso faltante
        public void Pass(int[] nums1, int[] nums2, double result)
        {
            Assert.Equal(result, Solution.FindMedianSortedArrays(nums1, nums2));
        }
    }
}
