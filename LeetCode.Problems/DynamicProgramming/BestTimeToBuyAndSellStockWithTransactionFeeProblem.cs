namespace LeetCode.Problems.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee
/// </summary>
public class BestTimeToBuyAndSellStockWithTransactionFeeProblem
{
    public int MaxProfit(int[] prices, int fee)
    {
        return MaxProfitDynamicProgrammingSpaceOptimised(prices, fee);
        return MaxProfitDynamicProgramming(prices, fee);
    }

    private static int MaxProfitDynamicProgrammingSpaceOptimised(int[] prices, int fee)
    {
        int n = prices.Length;
        int free = 0;
        int hold = -prices[0];

        for (int i = 0; i < n; i++)
        {
            int temp = hold;
            hold = Math.Max(hold, free - prices[i]);
            free = Math.Max(free, temp + prices[i] - fee);
        }

        return free;
    }

    private static int MaxProfitDynamicProgramming(int[] prices, int fee)
    {
        int n = prices.Length;

        int[] free = new int[n];
        int[] hold = new int[n];

        // In order to hold stock on day 0 we have no other choice but to buy it for prices[0]
        hold[0] = -prices[0];

        for (int i = 1; i < n; i++)
        {
            hold[i] = Math.Max(hold[i - 1], free[i - 1] - prices[i]);
            free[i] = Math.Max(free[i - 1], hold[i - 1] + prices[i] - fee);
        }

        return free[n - 1];
    }
}