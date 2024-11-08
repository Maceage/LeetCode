namespace LeetCode.Problems.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/remove-element
/// </summary>
public class RemoveElementProblem
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}