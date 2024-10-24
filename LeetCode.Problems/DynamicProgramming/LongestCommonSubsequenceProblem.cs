namespace LeetCode.Problems.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/longest-common-subsequence
/// </summary>
public class LongestCommonSubsequenceProblem
{
    private static int[,] _memo;

    private static string _text1;
    private static string _text2;

    public int LongestCommonSubsequence(string text1, string text2)
    {
        return LongestCommonSubsequenceDynamicProgrammingWithSpaceOptimisation(text1, text2);
        //return LongestCommonSubsequenceDynamicProgramming(text1, text2);
        //return LongestCommonSubsequenceImprovedMemoization(text1, text2);
        //return LongestCommonSubsequenceMemoization(text1, text2);
    }

    private static int LongestCommonSubsequenceDynamicProgrammingWithSpaceOptimisation(string text1, string text2)
    {
        // If text1 doesn't reference the shortest string then swap them
        if (text2.Length < text1.Length)
        {
            (text1, text2) = (text2, text1);
        }

        int[] previous = new int[text1.Length + 1];
        int[] current = new int[text1.Length + 1];

        for (int col = text2.Length - 1; col >= 0; col--)
        {
            for (int row = text1.Length - 1; row >= 0; row--)
            {
                if (text1[row] == text2[col])
                {
                    current[row] = 1 + previous[row + 1];
                }
                else
                {
                    current[row] = Math.Max(previous[row], current[row + 1]);
                }
            }

            // The current column becomes the previous one, and vice versa
            (previous, current) = (current, previous);
        }

        // The original problem's answer is in previous[0] so return it
        return previous[0];
    }

    private static int LongestCommonSubsequenceDynamicProgramming(string text1, string text2)
    {
        // Make grid of 0's with text2.length + 1 columns
        int[,] dpGrid = new int[text1.Length + 1, text2.Length + 1];

        for (int col = text2.Length - 1; col >= 0; col--)
        {
            for (int row = text1.Length - 1; row >= 0; row--)
            {
                if (text1[row] == text2[col])
                {
                    // If corresponding characters are the same...
                    dpGrid[row, col] = 1 + dpGrid[row + 1, col + 1];
                }
                else
                {
                    // Otherwise must be different...
                    dpGrid[row, col] = Math.Max(dpGrid[row + 1, col], dpGrid[row, col + 1]);
                }
            }
        }

        return dpGrid[0, 0];
    }

    private static int LongestCommonSubsequenceImprovedMemoization(string text1, string text2)
    {
        // Make memo big enough to hold cases where pointers go over edges of strings
        _memo = new int[text1.Length + 1, text2.Length + 1];

        // Initialise memo array to -1 so we know whether value has been filled
        // Keep base cases as 0's to simplify the later code
        for (int i = 0; i < text1.Length; i++)
        {
            for (int j = 0; j < text2.Length; j++)
            {
                _memo[i, j] = -1;
            }
        }

        _text1 = text1;
        _text2 = text2;

        return MemoSolveImproved(0, 0);
    }

    private static int MemoSolveImproved(int p1, int p2)
    {
        // Check whether subproblem has been solved
        // Also covers base cases where p1 = text1.length or p2 == text2.length
        if (_memo[p1, p2] != -1)
        {
            return _memo[p1, p2];
        }

        // Recursive cases
        int answer;

        if (_text1[p1] == _text2[p2])
        {
            answer = 1 + MemoSolveImproved(p1 + 1, p2 + 1);
        }
        else
        {
            answer = Math.Max(MemoSolveImproved(p1, p2 + 1), MemoSolveImproved(p1 + 1, p2));
        }

        // Add best answer to memo before returning
        _memo[p1, p2] = answer;

        return _memo[p1, p2];
    }

    private static int LongestCommonSubsequenceMemoization(string text1, string text2)
    {
        // Make memo big enough to hold cases where pointers go over edges of strings
        _memo = new int[text1.Length + 1, text2.Length + 1];

        // Initialise memo array to -1 so we know whether value has been filled
        // Keep base cases as 0's to simplify the later code
        for (int i = 0; i < text1.Length; i++)
        {
            for (int j = 0; j < text2.Length; j++)
            {
                _memo[i, j] = -1;
            }
        }

        _text1 = text1;
        _text2 = text2;

        return MemoSolve(0, 0);
    }

    private static int MemoSolve(int p1, int p2)
    {
        // Check whether subproblem has been solved
        // Also covers base cases where p1 = text1.length or p2 == text2.length
        if (_memo[p1, p2] != -1)
        {
            return _memo[p1, p2];
        }

        // Option 1: don't include text[p1] in the solution
        int option1 = MemoSolve(p1 + 1, p2);

        // Option 2: include text[p1] in solution as long as match for it in text2 at or after p2 exists
        int firstOccurence = _text2.IndexOf(_text1[p1], p2);
        int option2 = 0;

        if (firstOccurence != -1)
        {
            option2 = 1 + MemoSolve(p1 + 1, firstOccurence + 1);
        }

        // Add best answer to memo before returning
        _memo[p1, p2] = Math.Max(option1, option2);

        return _memo[p1, p2];
    }
}