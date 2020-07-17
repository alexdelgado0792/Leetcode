using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.ReverseInteger
{
    public static class Solution
    {
        public static int Reverse(int x)
        {
            string numberText = Math.Abs(x).ToString();
            string result = string.Empty;

            for (int i = numberText.Length - 1; i >= 0; i--)
            {
                result += numberText[i];
            }

            try 
            {
                int number = int.Parse(result);
                return (x > 0) ? number : (number * -1);
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
