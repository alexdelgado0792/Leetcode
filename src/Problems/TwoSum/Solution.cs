using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.TwoSum
{
    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var complements = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (complements.Contains(nums[i]))
                {
                    return new[] { complements.IndexOf(nums[i]), i };
                }
                else
                {
                    complements.Add(target - nums[i]);
                }
            }

            throw new Exception("No solution");
        }
    }
}
