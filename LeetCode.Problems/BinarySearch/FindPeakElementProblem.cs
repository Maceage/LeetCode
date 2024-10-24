namespace LeetCode.Problems.BinarySearch;

/// <summary>
/// https://leetcode.com/problems/find-peak-element
/// </summary>
public class FindPeakElementProblem
{
    public int FindPeakElement(int[] nums)
    {
        return FindPeakElementIterativeBinarySearch(nums);
        return FindPeakElementRecursiveBinarySearch(nums);
        return FindPeakElementLinearScan(nums);
    }

    private static int FindPeakElementIterativeBinarySearch(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] > nums[mid + 1])
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private static int FindPeakElementRecursiveBinarySearch(int[] nums)
    {
        return Search(nums, 0, nums.Length - 1);
    }

    private static int Search(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return left;
        }

        int mid = (left + right) / 2;

        if (nums[mid] > nums[mid + 1])
        {
            return Search(nums, 1, mid);
        }

        return Search(nums, mid + 1, right);
    }

    private static int FindPeakElementLinearScan(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                return i;
            }
        }

        return nums.Length - 1;
    }
}