namespace LeetCode.Problems;

public class ContainerWithTheMostWaterProblem
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int leftIndex = 0;
        int rightIndex = height.Length - 1;

        while (leftIndex < rightIndex)
        {
            int width = rightIndex - leftIndex;
            
            int leftValue = height[leftIndex];
            int rightValue = height[rightIndex];

            int minHeight = leftValue > rightValue ? rightValue : leftValue;

            int containerArea = minHeight * width;

            if (containerArea > maxArea)
            {
                maxArea = containerArea;
            }

            if (leftValue <= rightValue)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return maxArea;
    }

    //public int MaxArea(int[] height)
    //{
    //    int maxArea = 0;

    //    for (int i = 0; i < height.Length; i++)
    //    {
    //        int firstValue = height[i];

    //        for (int j = i + 1; j < height.Length; j++)
    //        {
    //            int secondValue = height[j];

    //            int minHeight = firstValue > secondValue ? secondValue : firstValue;
    //            int width = j - i;

    //            int containerArea = minHeight * width;

    //            if (containerArea > maxArea)
    //            {
    //                maxArea = containerArea;
    //            }
    //        }
    //    }

    //    return maxArea;
    //}
}