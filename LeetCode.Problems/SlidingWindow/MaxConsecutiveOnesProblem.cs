namespace LeetCode.Problems.SlidingWindow;

public class MaxConsecutiveOnesProblem
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int right;

        for (right = 0; right < nums.Length; right++)
        {
            int rightValue = nums[right];

            // Reduce k if we find a zero
            if (rightValue == 0)
            {
                k--;
            }

            // If left is zero then increase k again
            if (k < 0)
            {
                int leftValue = nums[left];

                k += 1 - leftValue;
                left++;
            }
        }

        return right - left;
    }
}