namespace LeetCode.Problems.Intervals;

/// <summary>
/// https://leetcode.com/problems/non-overlapping-intervals
/// </summary>
public class NonOverlappingIntervalsProblem
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        System.Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int ans = 0;
        int k = int.MinValue;

        foreach (var i in intervals)
        {
            int x = i[0];
            int y = i[1];

            if (x >= k)
            {
                k = y;
            }
            else
            {
                ans++;
            }
        }

        return ans;
    }
}