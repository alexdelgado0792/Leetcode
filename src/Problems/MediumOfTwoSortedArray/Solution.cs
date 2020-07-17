using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Problems.MediumOfTwoSortedArray
{
    public static class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] numbers = nums1.Concat(nums2).ToArray();
            Array.Sort(numbers);
            double result;

            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                var rIndex = numbers.Length / 2;
                var lIndex = rIndex - 1;

                result = (numbers[rIndex] + numbers[lIndex]) / 2.0;
            }
            else
            {
                result = (double) (nums1.Sum() + nums2.Sum()) / numbers.Length;
            }

            return result;
        }
    }
}
