namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/increasing-triplet-subsequence
/// </summary>
public class IncreasingTripletSubsequenceProblem
{
    public bool IncreasingTriplet(int[] nums)
    {
        bool result = false;

        int firstNum = int.MaxValue;
        int secondNum = int.MaxValue;

        foreach (var x in nums)
        {
            if (x <= firstNum)
            {
                firstNum = x;
            }
            else if (x <= secondNum)
            {
                secondNum = x;
            }
            else
            {
                result = true;
                break;
            }
        }

        return result;
    }
}