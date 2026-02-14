/*
LeetCode Problem: 53. Maximum Subarray
Link: https://leetcode.com/problems/maximum-subarray/description/

Description:
Given an integer array nums, find the contiguous subarray 
which has the largest sum and return its sum.
*/

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }

        return maxSum;
    }
}
