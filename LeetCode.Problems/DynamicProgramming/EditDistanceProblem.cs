namespace LeetCode.Problems.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/edit-distance
/// </summary>
public class EditDistanceProblem
{
    private static int?[][] _memo;

    public int MinDistance(string word1, string word2)
    {
        //return MinDistanceDynamicProgrammingTabulation(word1, word2);
        return MinDistanceDynamicProgrammingMemoization(word1, word2);
        return MinDistanceRecur(word1, word2, word1.Length, word2.Length);
    }

    private static int MinDistanceDynamicProgrammingTabulation(string word1, string word2)
    {
        int word1Length = word1.Length;
        int word2Length = word2.Length;

        if (word1Length == 0)
        {
            return word2Length;
        }

        if (word2Length == 0)
        {
            return word1Length;
        }

        int[,] dp = new int[word1Length + 1, word2Length + 1];

        for (int word1Index = 1; word1Index <= word1Length; word1Index++)
        {
            dp[word1Index, 0] = word1Index;
        }

        for (int word2Index = 1; word2Index <= word2Length; word2Index++)
        {
            dp[0, word2Index] = word2Index;
        }

        for (int word1Index = 1; word1Index <= word1Length; word1Index++)
        {
            for (int word2Index = 1; word2Index <= word2Length; word2Index++)
            {
                if (word2[word2Index - 1] == word1[word1Index - 1])
                {
                    dp[word1Index, word2Index] = dp[word1Index - 1, word2Index - 1];
                }
                else
                {
                    dp[word1Index, word2Index] = Math.Min(dp[word1Index - 1, word2Index], 
                        Math.Min(dp[word1Index, word2Index - 1], 
                            dp[word1Index - 1, word2Index - 1])) + 1;
                }
            }
        }

        return dp[word1Length, word2Length];
    }

    private static int MinDistanceDynamicProgrammingMemoization(string word1, string word2)
    {
        _memo = new int?[word1.Length + 1][];

        for (int i = 0; i <= word1.Length; i++)
        {
            _memo[i] = new int?[word2.Length + 1];
        }

        return MinDistanceRecurDynamicProgrammingMemoization(word1, word2, word1.Length, word2.Length);
    }

    private static int MinDistanceRecurDynamicProgrammingMemoization(string word1, string word2, int word1Index, int word2Index)
    {
        if (word1Index == 0)
        {
            return word2Index;
        }

        if (word2Index == 0)
        {
            return word1Index;
        }

        if (_memo[word1Index][word2Index].HasValue)
        {
            return _memo[word1Index][word2Index]!.Value;
        }

        int minEditDistance = 0;

        if (word1[word1Index - 1] == word2[word2Index - 1])
        {
            minEditDistance = MinDistanceRecurDynamicProgrammingMemoization(word1, word2, word1Index - 1, word2Index - 1);
        }
        else
        {
            int insertOperation = MinDistanceRecurDynamicProgrammingMemoization(word1, word2, word1Index, word2Index - 1);
            int deleteOperation = MinDistanceRecurDynamicProgrammingMemoization(word1, word2, word1Index - 1, word2Index);
            int replaceOperation = MinDistanceRecurDynamicProgrammingMemoization(word1, word2, word1Index - 1, word2Index - 1);

            minEditDistance = Math.Min(insertOperation, Math.Min(deleteOperation, replaceOperation)) + 1;
        }

        _memo[word1Index][word2Index] = minEditDistance;

        return minEditDistance;
    }

    private static int MinDistanceRecur(string word1, string word2, int word1Index, int word2Index)
    {
        if (word1Index == 0)
        {
            return word2Index;
        }

        if (word2Index == 0)
        {
            return word1Index;
        }

        if (word1[word1Index - 1] == word2[word2Index - 1])
        {
            return MinDistanceRecur(word1, word2, word1Index - 1, word2Index - 1);
        }

        int insertOperation = MinDistanceRecur(word1, word2, word1Index, word2Index - 1);
        int deleteOperation = MinDistanceRecur(word1, word2, word1Index - 1, word2Index);
        int replaceOperation = MinDistanceRecur(word1, word2, word1Index - 1, word2Index - 1);

        return Math.Min(insertOperation, Math.Min(deleteOperation, replaceOperation)) + 1;
    }
}