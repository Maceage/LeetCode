namespace LeetCode.Problems;

public class ProductOfArrayExceptSelfProblem
{
    public int[] ProductExceptSelf(int[] nums)
    {
        return ProductExceptSelfLeftAndRightProductLists(nums);
        return ProductExceptSelfSpaceApproach(nums);
    }

    private static int[] ProductExceptSelfLeftAndRightProductLists(int[] nums)
    {
        int length = nums.Length;

        int[] leftProducts = new int[length];
        int[] rightProducts = new int[length];

        leftProducts[0] = 1;

        for (int i = 1; i < length; i++)
        {
            leftProducts[i] = nums[i - 1] * leftProducts[i - 1];
        }

        rightProducts[length - 1] = 1;

        for (int i = length - 2; i >= 0; i--)
        {
            rightProducts[i] = nums[i + 1] * rightProducts[i + 1];
        }

        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = rightProducts[i] * leftProducts[i];
        }

        return result;
    }

    private static int[] ProductExceptSelfSpaceApproach(int[] nums)
    {
        int[] resultNums = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int? result = null;

            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                {
                    int currentNum = nums[j];

                    if (!result.HasValue)
                    {
                        result = currentNum;
                    }
                    else
                    {
                        result *= currentNum;
                    }
                }
            }

            resultNums[i] = result ?? 0;
        }

        return resultNums;
    }
}