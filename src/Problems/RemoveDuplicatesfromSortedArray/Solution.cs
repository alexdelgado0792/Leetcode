using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.RemoveDuplicatesfromSortedArray
{
    public static class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }

            }
            return i + 1;
        }

        public static int[] RemoveDuplicate2(int[] nums)
        {
            var new_nums = new List<int>();

            foreach (var number in nums)
            {
                if (!new_nums.Contains(number))
                {
                    new_nums.Add(number);
                }
            }

            return new_nums.ToArray();
        }
    }
}
