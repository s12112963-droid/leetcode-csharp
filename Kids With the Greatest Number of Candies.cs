/*
LeetCode Problem: 1431. Kids With the Greatest Number of Candies
Link: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/

Description:
Given an array candies and an integer extraCandies,
return a list of booleans where each element is true
if the child can have the greatest number of candies
after adding extraCandies.
*/

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> result = new List<bool>();

        int max = candies[0];


        for (int i = 1; i < candies.Length; i++)
        {
            if (candies[i] > max)
            {
                max = candies[i];
            }
        }


        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}
