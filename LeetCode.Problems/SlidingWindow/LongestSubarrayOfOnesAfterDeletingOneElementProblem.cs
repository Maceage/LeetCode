namespace LeetCode.Problems;

public class LongestSubarrayOfOnesAfterDeletingOneElementProblem
{
    public int LongestSubarray(int[] nums)
    {
        int longestSubarray = 0;

        int left = 0;
        int right = 1;

        int lastZeroIndex = -1;

        if (nums[left] == 0)
        {
            lastZeroIndex = 0;
        }

        while (right < nums.Length)
        {
            int rightValue = nums[right];

            if (rightValue == 1)
            {
                right++;
            }
            else if (rightValue == 0)
            {
                left = lastZeroIndex + 1;
                lastZeroIndex = right;

                right++;
            }

            int subArrayLength = right - left;

            longestSubarray = Math.Max(longestSubarray, subArrayLength);
        }

        longestSubarray = longestSubarray > 0 ? longestSubarray - 1 : 0;

        return longestSubarray;
    }
}