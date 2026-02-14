/*
LeetCode Problem: 121. Best Time to Buy and Sell Stock
Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

Description:
Given an array where prices[i] is the price of a stock on day i,
find the maximum profit you can achieve by buying once and selling once.
*/

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minprice = prices[0];
        int maxprofit = 0;
        int profit;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minprice)
                minprice = prices[i];

            profit = prices[i] - minprice;

            if (profit > maxprofit)
                maxprofit = profit;

        }
        return maxprofit;
    }
}