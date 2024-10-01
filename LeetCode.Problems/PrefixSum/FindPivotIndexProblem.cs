namespace LeetCode.Problems.PrefixSum;

public class FindPivotIndexProblem
{
    public int PivotIndex(int[] nums)
    {
        int pivotIndex = -1;

        int leftIndex = 1;
        int rightIndex = nums.Length - 2;

        int[] leftSum = new int[nums.Length];
        int[] rightSum = new int[nums.Length];

        leftSum[0] = nums[0];
        rightSum[nums.Length - 1] = nums[nums.Length - 1];

        while (leftIndex <= nums.Length && rightIndex >= 0)
        {
            int leftValue = nums[leftIndex];
            int rightValue = nums[rightIndex];

            int leftPreviousIndex = leftIndex - 1;
            int rightPreviousIndex = rightIndex + 1;

            leftSum[leftIndex] = leftSum[leftPreviousIndex] + leftValue;
            rightSum[rightIndex] = rightSum[rightPreviousIndex] + rightValue;

            leftIndex++;
            rightIndex--;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum[i] == rightSum[i])
            {
                pivotIndex = i;
                break;
            }
        }

        return pivotIndex;
    }
}