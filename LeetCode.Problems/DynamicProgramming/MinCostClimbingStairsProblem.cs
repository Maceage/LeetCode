namespace LeetCode.Problems.DynamicProgramming;

public class MinCostClimbingStairsProblem
{
    private static readonly Dictionary<int, int> _memo = new();

    public int MinCostClimbingStairs(int[] cost)
    {
        return MinCostClimbingStairsBottomUpConstantSpace(cost);
        return MinCostClimbingStairsBottomUpDynamicProgramming(cost);
        return MinCostClimbingStairsTopDownDynamicProgramming(cost);
    }

    private static int MinCostClimbingStairsBottomUpConstantSpace(int[] cost)
    {
        int downOne = 0;
        int downTwo = 0;

        for (int i = 2; i < cost.Length + 1; i++)
        {
            int temp = downOne;

            downOne = Math.Min(downOne + cost[i - 1], downTwo + cost[i - 2]);

            downTwo = temp;
        }

        return downOne;
    }

    private static int MinimumCost(int i, int[] cost)
    {
        if (i <= 1)
        {
            return 0;
        }

        if (_memo.TryGetValue(i, out var minimumCost))
        {
            return minimumCost;
        }

        int downOne = cost[i - 1] + MinimumCost(i - 1, cost);
        int downTwo = cost[i - 2] + MinimumCost(i - 2, cost);

        _memo.Add(i, Math.Min(downOne, downTwo));

        return _memo[i];
    }

    private static int MinCostClimbingStairsTopDownDynamicProgramming(int[] cost)
    {
        return MinimumCost(cost.Length, cost);
    }

    private static int MinCostClimbingStairsBottomUpDynamicProgramming(int[] cost)
    {
        int[] dp = new int[cost.Length + 1];

        for (int i = 2; i < dp.Length; i++)
        {
            int takeOneStep = dp[i - 1] + cost[i - 1];
            int takeTwoSteps = dp[i - 2] + cost[i - 2];

            dp[i] = Math.Min(takeOneStep, takeTwoSteps);
        }
        
        return dp[^1];
    }
}