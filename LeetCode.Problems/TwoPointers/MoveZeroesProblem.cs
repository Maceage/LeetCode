namespace LeetCode.Problems.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/move-zeroes
/// </summary>
public class MoveZeroesProblem
{
    public void MoveZeroes(int[] nums)
    {
        MoveZeroesOptimal(nums);
        //MoveZeroesSpaceOptimalOperationSubOptimal(nums);
        //MoveZeroesSpaceSubOptimal(nums);
    }

    private static void MoveZeroesOptimal(int[] nums)
    {
        for (int lastNonZeroIndex = 0, currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            if (nums[currentIndex] != 0)
            {
                int current = nums[currentIndex];

                nums[lastNonZeroIndex++] = current;

                nums[currentIndex] = 0;
            }
        }
    }

    private static void MoveZeroesSpaceOptimalOperationSubOptimal(int[] nums)
    {
        int lastNonZeroIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[lastNonZeroIndex++] = nums[i];
            }
        }

        for (int i = lastNonZeroIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }

    private static void MoveZeroesSpaceSubOptimal(int[] nums)
    {
        int[] newArray = new int[nums.Length];

        int zeroCount = 0;

        foreach (var t in nums)
        {
            if (t == 0)
            {
                zeroCount++;
            }
        }

        int x = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                newArray[x] = nums[i];
                x++;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = newArray[i];
        }
    }
}