namespace LeetCode.Problems.PrefixSum;

/// <summary>
/// https://leetcode.com/problems/find-the-highest-altitude
/// </summary>
public class FindTheHighestAltitudeProblem
{
    public int LargestAltitude(int[] gain)
    {
        int currentGain = 0;
        int highestAltitude = 0;

        foreach (var g in gain)
        {
            currentGain += g;

            highestAltitude = Math.Max(highestAltitude, currentGain);
        }

        return highestAltitude;
    }
}