using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.LenghtLastWord
{
    public static class Solution
    {
        public static int LengthOfLastWord(string s)
        {
            return s.Trim().Split(' ')[^1].Length;
        }
    }
}
