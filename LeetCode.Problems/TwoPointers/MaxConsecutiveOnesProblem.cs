namespace LeetCode.Problems.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/max-consecutive-ones/
/// </summary>
public class MaxConsecutiveOnesProblem
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int result = 0;
        int maxOnes = 0;

        foreach (var current in nums)
        {
            if (current == 1)
            {
                maxOnes++;
            }
            else
            {
                maxOnes = 0;
            }

            result = Math.Max(maxOnes, result);
        }

        return result;
    }
}