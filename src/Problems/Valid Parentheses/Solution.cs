using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Valid_Parentheses
{
    public static class Solution
    {
        public static bool IsValid(string s)
        {
            if (s.Length == 0) return true;
            if (s.Length == 1) return false;

            Stack<char> stack = new Stack<char>();

            foreach (char character in s)
            {
                if ((character == '}' || character == ']' || character == ')') && stack.Count > 0)
                {
                    var peek = stack.Peek();

                    if (character == '}' && peek == '{')
                    {
                        stack.Pop();
                    }
                    else
                    if (character == ']' && peek == '[')
                    {
                        stack.Pop();
                    }
                    else if (character == ')' && peek == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(character);
                    }
                }
                else
                {
                    stack.Push(character);
                }
            }

            return stack.Count == 0;
        }

        public static bool Approach1(string s)
        {
            if (s.Length == 0) return true;
            if (s.Length == 1) return false;

            Stack<char> stack = new Stack<char>();

            foreach (char character in s)
            {
                if ((character == '}' || character == ']' || character == ')') && stack.Count > 0)
                {

                    if (character == '}' && stack.Pop() != '{')
                    {
                        return false;
                    }
                    if (character == ']' && stack.Pop() != '[')
                    {
                        return false;
                    }
                    if (character == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(character);
                }

            }

            return stack.Count == 0;
        }
    }
}
