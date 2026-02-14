/*
LeetCode Problem: 344. Reverse String
Link: https://leetcode.com/problems/reverse-string/description/

Description:
Write a function that reverses a character array in-place.
The function should modify the input array directly
and use only constant extra memory.
*/

using System;
public class Solution
{
    public void ReverseString(char[] s)
    {
        char x;
        int left = 0;
        int right = (s.Length) - 1;
        while (left < right)
        {
            x = s[left];
            s[left] = s[right];
            s[right] = x;
            left++;
            right--;
        }

    }
}
