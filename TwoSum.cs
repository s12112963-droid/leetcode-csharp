/*
LeetCode Problem: 1. Two Sum
Link: https://leetcode.com/problems/two-sum/

Description:
Given an array of integers nums and an integer target,
return indices of the two numbers such that they add up to target.
*/

using System;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {


        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }

            }

        }
        return new int[] { };

    }
}