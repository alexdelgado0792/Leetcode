using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Implement_strStr
{
    public static class Solution
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == string.Empty)
            {
                return 0;
            }

            return haystack.IndexOf(needle);
        }
    }
}
