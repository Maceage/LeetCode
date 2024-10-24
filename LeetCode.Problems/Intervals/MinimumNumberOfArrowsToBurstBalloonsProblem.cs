namespace LeetCode.Problems.Intervals;

/// <summary>
/// https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons
/// </summary>
public class MinimumNumberOfArrowsToBurstBalloonsProblem
{
    public int FindMinArrowShots(int[][] points)
    {
        System.Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        int arrows = 1;
        int k = int.MinValue;
        int lastEnd = points[0][1];

        foreach (var p in points)
        {
            int xStart = p[0];
            int xEnd = p[1];

            if (lastEnd < xStart)
            {
                arrows++;
                lastEnd = xEnd;
            }
        }

        return arrows;
    }
}