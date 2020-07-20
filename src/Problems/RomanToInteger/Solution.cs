using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.RomanToInteger
{
    public static class Solution
    {
        public static int RomanToInt(string s)
        {
            var romanDic = new Dictionary<char, int>()
            {
                { 'I' , 1 },{ 'V' , 5 },{ 'X' , 10 },{ 'L' , 50 },{ 'C' , 100 },{ 'D' , 500 },{ 'M' , 1000 },
            };

            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1 && romanDic[s[i]] < romanDic[s[i + 1]])
                {
                    number += romanDic[s[i + 1]] - romanDic[s[i]];
                    i++;
                }
                else
                {
                    number += romanDic[s[i]];
                }
            }

            return number;
        }
    }
}
