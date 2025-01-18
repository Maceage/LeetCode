namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/contains-duplicate
/// </summary>
public class ContainsDuplicateProblem
{
    public bool ContainsDuplicate(int[] nums)
    {
        bool containsDuplicate = false;

        HashSet<int> hashSet = new HashSet<int>();

        if (nums != null)
        {
            foreach (int num in nums)
            {
                if (!hashSet.Add(num))
                {
                    containsDuplicate = true;
                    break;
                }
            }
        }

        return containsDuplicate;
    }
}