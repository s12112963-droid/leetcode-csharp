/*
LeetCode Problem: 169. Majority Element
Link: https://leetcode.com/problems/majority-element/description/

Description:
Given an array nums of size n, return the majority element.
The majority element is the element that appears more than n/2 times.
*/


public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < n; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }

            if (count > n / 2)
            {
                return nums[i];
            }
        }

        return -1;
    }
}
