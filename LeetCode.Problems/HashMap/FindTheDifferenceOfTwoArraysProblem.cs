namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/find-the-difference-of-two-arrays
/// </summary>
public class FindTheDifferenceOfTwoArraysProblem
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        Dictionary<int, bool> nums1Dictionary = new Dictionary<int, bool>();
        Dictionary<int, bool> nums2Dictionary = new Dictionary<int, bool>();

        foreach (var nums1Value in nums1)
        {
            nums1Dictionary.TryAdd(nums1Value, true);
        }

        foreach (var nums2Value in nums2)
        {
            nums2Dictionary.TryAdd(nums2Value, true);
        }

        List<int> nums1Distinct = new List<int>();

        foreach (var nums1Value in nums1)
        {
            if (!nums2Dictionary.ContainsKey(nums1Value) && !nums1Distinct.Contains(nums1Value))
            {
                nums1Distinct.Add(nums1Value);
            }
        }

        List<int> nums2Distinct = new List<int>();

        foreach (var nums2Value in nums2)
        {
            if (!nums1Dictionary.ContainsKey(nums2Value) && !nums2Distinct.Contains(nums2Value))
            {
                nums2Distinct.Add(nums2Value);
            }
        }

        return new List<IList<int>>
        {
            nums1Distinct,
            nums2Distinct,
        };
    }
}