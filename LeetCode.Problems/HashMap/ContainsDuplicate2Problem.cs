namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/contains-duplicate-ii
/// </summary>
public class ContainsDuplicate2Problem
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        return ContainsNearbyDuplicateHashTable(nums, k);
        return ContainsNearbyDuplicateBinarySearchTree(nums, k);
        return ContainsNearbyDuplicateNaiveLinearSearch(nums, k);
    }

    private static bool ContainsNearbyDuplicateHashTable(int[] nums, int k)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i]))
            {
                return true;
            }

            if (set.Count > k)
            {
                set.Remove(nums[i - k]);
            }
        }

        return false;
    }

    private static bool ContainsNearbyDuplicateBinarySearchTree(int[] nums, int k)
    {
        SortedSet<int> set = new SortedSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i]))
            {
                return true;
            }

            if (set.Count > k)
            {
                set.Remove(nums[i - k]);
            }
        }

        return false;
    }

    private static bool ContainsNearbyDuplicateNaiveLinearSearch(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = Math.Max(i - k, 0); j < i; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }
}