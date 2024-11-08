namespace LeetCode.Problems.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/array-partition
/// </summary>
public class ArrayPartitionProblem
{
    private static int K = 10000;

    public int ArrayPairSum(int[] nums)
    {
        return ArrayPairSumCountingSort(nums);
        return ArrayPairSumSorting(nums);
    }

    private static int ArrayPairSumCountingSort(int[] nums)
    {
        int[] elementToCount = new int[2 * K + 1];

        foreach (int num in nums)
        {
            elementToCount[num + K]++;
        }

        int maxSum = 0;
        bool isEvenIndex = true;

        for (int i = 0; i <= 2 * K; i++)
        {
            while (elementToCount[i] > 0)
            {
                maxSum += (isEvenIndex ? i - K : 0);

                isEvenIndex = !isEvenIndex;

                elementToCount[i]--;
            }
        }

        return maxSum;
    }

    private static int ArrayPairSumSorting(int[] nums)
    {
        int result = 0;

        System.Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
        {
            result += nums[i];
        }

        return result;
    }
}