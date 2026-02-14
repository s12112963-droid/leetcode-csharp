/*
LeetCode Problem: 125. Valid Palindrome
Link: https://leetcode.com/problems/valid-palindrome/description/

Description:
Given a string, determine if it is a palindrome,
considering only alphanumeric characters and ignoring cases.
*/

using System;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {

            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }


            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
