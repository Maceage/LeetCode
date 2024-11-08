namespace LeetCode.Problems.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted
/// </summary>
public class TwoSumInputArrayIsSortedProblem
{
    public int[] TwoSum(int[] numbers, int target)
    {
        return TwoSumTwoPointers(numbers, target);
        return TwoSumBinarySearch(numbers, target);
    }

    private static int[] TwoSumTwoPointers(int[] numbers, int target)
    {
        int low = 0;
        int high = numbers.Length - 1;

        while (low < high)
        {
            int sum = numbers[low] + numbers[high];

            if (sum == target)
            {
                return [low + 1, high + 1];
            }
            else if (sum < target)
            {
                ++low;
            }
            else
            {
                --high;
            }
        }

        return [-1, -1];
    }

    private static int[] TwoSumBinarySearch(int[] numbers, int target)
    {
        int firstIndex = -1;
        int secondIndex = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int current = numbers[i];

            int numToFind = target - current;

            int left = i + 1;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (numbers[mid] == numToFind)
                {
                    firstIndex = i;
                    secondIndex = mid;
                    break;
                }

                if (numbers[mid] > numToFind)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if ((firstIndex >= 0) && (secondIndex >= 0))
            {
                break;
            }
        }

        return [firstIndex + 1, secondIndex + 1];
    }
}