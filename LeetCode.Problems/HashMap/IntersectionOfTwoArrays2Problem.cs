namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/intersection-of-two-arrays-ii
/// </summary>
public class IntersectionOfTwoArrays2Problem
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        return IntersectWithSort(nums1, nums2);
        return IntersectWithHashMap(nums1, nums2);
    }

    private static int[] IntersectWithSort(int[] nums1, int[] nums2)
    {
        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                ++i;
            }
            else if (nums1[i] > nums2[j])
            {
                ++j;
            }
            else
            {
                nums1[k++] = nums1[i++];
                ++j;
            }
        }

        return nums1.Take(k).ToArray();
    }

    private static int[] IntersectWithHashMap(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            return IntersectWithHashMap(nums2, nums1);
        }

        Dictionary<int, int> m = new Dictionary<int, int>();

        foreach (int i in nums1)
        {
            if (!m.TryAdd(i, 1))
            {
                m[i] = m.GetValueOrDefault(i, 0) + 1;
            }
        }

        int k = 0;

        foreach (int i in nums2)
        {
            int count = m.GetValueOrDefault(i, 0);

            if (count > 0)
            {
                nums1[k++] = i;

                if (!m.TryAdd(i, count - 1))
                {
                    m[i] = count - 1;
                }
            }
        }

        return nums1.Take(k).ToArray();
    }
}