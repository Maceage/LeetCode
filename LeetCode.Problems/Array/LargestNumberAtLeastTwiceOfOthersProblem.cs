namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/largest-number-at-least-twice-of-others/
/// </summary>
public class LargestNumberAtLeastTwiceOfOthersProblem
{
    public int DominantIndex(int[] nums)
    {
        int dominantIndex = -1;

        int largest = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > largest)
            {
                largest = nums[i];
                dominantIndex = i;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != dominantIndex)
            {
                int calculated = nums[i] * 2;

                if (calculated > largest)
                {
                    dominantIndex = -1;
                    break;
                }
            }
        }

        return dominantIndex;
    }
}