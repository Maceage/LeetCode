namespace LeetCode.Problems.DynamicProgramming;

public class HouseRobberProblem
{
    private static int[] _cache;

    public int Rob(int[] nums)
    {
        return RobOptimisedDynamicProgramming(nums);
        return RobRecursionWithMemoization(nums);
        return RobDynamicProgramming(nums);
    }

    private static int RobOptimisedDynamicProgramming(int[] nums)
    {
        int n = nums.Length;

        if (n == 0)
        {
            return 0;
        }

        var robNextPlusOne = 0;
        var robNext = nums[n - 1];

        for (int i = n - 2; i >= 0; --i)
        {
            int current = Math.Max(robNext, robNextPlusOne + nums[i]);

            robNextPlusOne = robNext;
            robNext = current;
        }

        return robNext;
    }

    private static int RobDynamicProgramming(int[] nums)
    {
        int n = nums.Length;

        if (n == 0)
        {
            return 0;
        }

        int[] maxRobbedAmount = new int[nums.Length + 1];

        maxRobbedAmount[n] = 0;
        maxRobbedAmount[n - 1] = nums[n - 1];

        for (int i = n - 2; i >= 0; --i)
        {
            maxRobbedAmount[i] = Math.Max(
                maxRobbedAmount[i + 1],
                maxRobbedAmount[i + 2] + nums[i]);
        }

        return maxRobbedAmount[0];
    }

    private static int RobRecursionWithMemoization(int[] nums)
    {
        _cache = new int[nums.Length];

        System.Array.Fill(_cache, -1);

        return RobFrom(0, nums);
    }

    private static int RobFrom(int i, int[] nums)
    {
        if (i >= nums.Length)
        {
            return 0;
        }

        if (_cache[i] > -1)
        {
            return _cache[i];
        }

        int answer = Math.Max(RobFrom(i + 1, nums), RobFrom(i + 2, nums) + nums[i]);

        _cache[i] = answer;

        return answer;
    }
}