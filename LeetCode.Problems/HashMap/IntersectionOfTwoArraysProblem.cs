namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/intersection-of-two-arrays
/// </summary>
public class IntersectionOfTwoArraysProblem
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        return IntersectionWithTwoSets(nums1, nums2);
        return IntersectionBuiltInSetIntersection(nums1, nums2);
        return IntersectionTwoPointers(nums1, nums2);
        return IntersectionOriginal(nums1, nums2);
    }

    private static int[] IntersectionWithTwoSets(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>();

        foreach (var i in nums1)
        {
            set1.Add(i);
        }

        HashSet<int> set2 = new HashSet<int>();

        foreach (int i in nums2)
        {
            set2.Add(i);
        }

        if (set1.Count < set2.Count)
        {
            return SetIntersection(set1, set2);
        }

        return SetIntersection(set2, set1);
    }

    private static int[] SetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        int[] output = new int[set1.Count];
        int index = 0;

        foreach (int i in set1)
        {
            if (set2.Contains(i))
            {
                output[index++] = i;
            }
        }

        return output.Take(index).Select(i => i).ToArray();
    }

    private static int[] IntersectionBuiltInSetIntersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>();

        foreach (int i in nums1)
        {
            set1.Add(i);
        }

        HashSet<int> set2 = new HashSet<int>();

        foreach (int i in nums2)
        {
            set2.Add(i);
        }

        set1.RemoveWhere(i => !set2.Contains(i));

        int[] output = new int[set1.Count()];

        int index = 0;

        foreach (int i in set1)
        {
            output[index++] = i;
        }

        return output;
    }

    private static int[] IntersectionTwoPointers(int[] nums1, int[] nums2)
    {
        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        int n = nums1.Length;
        int m = nums2.Length;

        int p1 = 0;
        int p2 = 0;

        HashSet<int> intersection = new HashSet<int>();

        while (p1 < n && p2 < m)
        {
            if (nums1[p1] == nums2[p2])
            {
                intersection.Add(nums1[p1]);

                p1++;
                p2++;
            }
            else if (nums1[p1] < nums2[p2])
            {
                p1++;
            }
            else
            {
                p2++;
            }
        }

        int k = intersection.Count;
        int[] result = new int[k];
        int current = 0;

        foreach (int i in intersection)
        {
            result[current++] = i;
        }

        return result;
    }

    private static int[] IntersectionOriginal(int[] nums1, int[] nums2)
    {
        List<int> intersectionNumbers = new List<int>();

        HashSet<int> numbers = new HashSet<int>();

        foreach (int i in nums1)
        {
            numbers.Add(i);
        }

        foreach (int i in nums2)
        {
            if ((numbers.Contains(i)) && (!intersectionNumbers.Contains(i)))
            {
                intersectionNumbers.Add(i);
            }
        }


        return intersectionNumbers.ToArray();
    }
}