/*
LeetCode Problem: 20. Valid Parentheses
Link: https://leetcode.com/problems/valid-parentheses/

Description:
Given a string containing only the characters '(', ')', '{', '}', '[' and ']',
determine if the input string is valid.

A string is valid if:
- Open brackets are closed by the same type of brackets.
- Open brackets are closed in the correct order.

*/


using System;

public class Solution
{
    public bool IsValid(string s)
    {

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
            }
            if (s[i] == ')')
            {
                if (stack.Count == 0)
                    return false;
                if (stack.Peek() != '(')
                    return false;
                else
                    stack.Pop();
            }

            if (s[i] == '}')
            {
                if (stack.Count == 0)
                    return false;
                if (stack.Peek() != '{')
                    return false;
                else
                    stack.Pop();
            }

            if (s[i] == ']')
            {
                if (stack.Count == 0)
                    return false;
                if (stack.Peek() != '[')
                    return false;
                else
                    stack.Pop();

            }


        }

        if (stack.Count == 0)
            return true;
        else
            return false;

    }
}
