/*
LeetCode Problem: 704. Binary Search
Link: https://leetcode.com/problems/binary-search/description/

Description:
Given a sorted array of integers nums and an integer target,
return the index of the target if it exists in the array.
If it does not exist, return -1.
*/


using System;
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
