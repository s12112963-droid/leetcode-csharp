/*
LeetCode Problem: 217. Contains Duplicate
Link: https://leetcode.com/problems/contains-duplicate/

Description:
Given an integer array nums, return true if any value appears 
at least twice in the array, and return false if every element is distinct.
*/

using System;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {

        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (set.Contains(nums[i]))
                return true;
            else
                set.Add(nums[i]);

        }
        return false;
    }
}