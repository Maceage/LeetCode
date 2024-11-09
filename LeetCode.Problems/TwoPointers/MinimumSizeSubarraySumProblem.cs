namespace LeetCode.Problems.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/minimum-size-subarray-sum
/// </summary>
public class MinimumSizeSubarraySumProblem
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        int right = 0;
        int sumOfCurrentWindow = 0;

        int result = int.MaxValue;

        for (right = 0; right < nums.Length; right++)
        {
            sumOfCurrentWindow += nums[right];

            while (sumOfCurrentWindow >= target)
            {
                result = Math.Min(result, right - left + 1);

                sumOfCurrentWindow -= nums[left++];
            }
        }

        return result == int.MaxValue ? 0 : result;
    }
}