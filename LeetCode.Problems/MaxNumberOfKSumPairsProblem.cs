﻿namespace LeetCode.Problems;

public class MaxNumberOfKSumPairsProblem
{
    public int MaxOperations(int[] nums, int k)
    {
        int totalOperations = 0;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];

            if (!map.ContainsKey(current))
            {
                map[current] = 1;
            }
            else
            {
                map[current]++;
            }
        }

        foreach (int current in map.Keys)
        {
            int calculated = k - current;

            if (calculated > 0)
            {
                if (map.ContainsKey(calculated))
                {
                    while (map.ContainsKey(current) && map.ContainsKey(calculated))
                    {
                        if (map[current] == 1)
                        {
                            map.Remove(current);

                            if (calculated == current)
                            {
                                break;
                            }
                        }
                        else
                        {
                            map[current]--;
                        }

                        if (map[calculated] == 1)
                        {
                            map.Remove(calculated);
                        }
                        else
                        {
                            map[calculated]--;
                        }

                        totalOperations++;
                    }
                }
            }
        }

        return totalOperations;
    }
}