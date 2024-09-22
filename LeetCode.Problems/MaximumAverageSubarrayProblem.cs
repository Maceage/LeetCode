namespace LeetCode.Problems;

public class MaximumAverageSubarrayProblem
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double result = sum;

        for (int i = k; i < nums.Length; i++)
        {
            int current = nums[i];
            
            int startIndex = i - k;
            int previousSum = nums[startIndex];

            sum += current - previousSum;

            result = Math.Max(result, sum);
        }

        return result / k;
    }

    //public double FindMaxAverage(int[] nums, int k)
    //{
    //    int[] sum = new int[nums.Length];

    //    sum[0] = nums[0];

    //    for (int i = 1; i < nums.Length; i++)
    //    {
    //        int current = nums[i];
    //        int previousSum = sum[i - 1];

    //        sum[i] = previousSum + current;
    //    }

    //    double result = sum[k - 1] * 1.0 / k;

    //    for (int i = k; i < nums.Length; i++)
    //    {
    //        double newResult = (sum[i] - sum[i - k]) * 1.0 / k;

    //        result = Math.Max(result, newResult);
    //    }

    //    return result;
    //}
}