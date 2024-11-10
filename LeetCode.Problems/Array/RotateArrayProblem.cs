namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/rotate-array/
/// </summary>
public class RotateArrayProblem
{
    public void Rotate(int[] nums, int k)
    {
        RotateUsingReverse(nums, k);
        //RotateUsingCyclicReplacements(nums, k);
        //RotateWithAdditionalArray(nums, k);
        //RotateBruteForce(nums, k);
    }

    private static void RotateUsingReverse(int[] nums, int k)
    {
        k %= nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private static void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }

    private static void RotateUsingCyclicReplacements(int[] nums, int k)
    {
        k %= nums.Length;

        int count = 0;

        for (int start = 0; count < nums.Length; start++)
        {
            int current = start;
            int previous = nums[start];

            do
            {
                int next = (current + k) % nums.Length;
                int temp = nums[next];

                nums[next] = previous;
                previous = temp;
                current = next;
                count++;
            }
            while (start != current);
        }
    }

    private static void RotateWithAdditionalArray(int[] nums, int k)
    {
        int[] newArray = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int addition = i + k;
            int targetIndex = addition % nums.Length;

            newArray[targetIndex] = nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = newArray[i];
        }
    }

    private static void RotateBruteForce(int[] nums, int k)
    {
        int i = 0;

        while (i < k)
        {
            int lastNum = nums[^1];

            for (int j = nums.Length - 1; j >= 1; j--)
            {
                nums[j] = nums[j - 1];
            }

            nums[0] = lastNum;

            i++;
        }
    }
}