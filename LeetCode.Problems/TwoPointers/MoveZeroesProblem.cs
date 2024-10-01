namespace LeetCode.Problems.TwoPointers;

public class MoveZeroesProblem
{
    public void MoveZeroes(int[] nums)
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

    //public void MoveZeroes(int[] nums)
    //{
    //    for (int lastNonZeroIndex = 0, currentIndex = 0; currentIndex < nums.Length; currentIndex++)
    //    {
    //        if (nums[currentIndex] != 0)
    //        {
    //            int current = nums[currentIndex];

    //            nums[lastNonZeroIndex++] = current;

    //            nums[currentIndex] = 0;
    //        }
    //    }
    //}

    //public void MoveZeroes(int[] nums)
    //{
    //    int[] newArray = new int[nums.Length];

    //    int zeroCount = 0;

    //    foreach (var t in nums)
    //    {
    //        if (t == 0)
    //        {
    //            zeroCount++;
    //        }
    //    }

    //    int x = 0;

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (nums[i] != 0)
    //        {
    //            newArray[x] = nums[i];
    //            x++;
    //        }
    //    }

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        nums[i] = newArray[i];
    //    }
    //}
}