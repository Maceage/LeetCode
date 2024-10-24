namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/two-sum
/// </summary>
public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            map[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement) && map[complement] != i)
            {
                return [i, map[complement]];
            }
        }

        return null;
    }
}