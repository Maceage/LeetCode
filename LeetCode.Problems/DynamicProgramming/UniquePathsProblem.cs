namespace LeetCode.Problems.DynamicProgramming;

public class UniquePathsProblem
{
    public int UniquePaths(int m, int n)
    {
        return UniquePathsMaths(m, n);
        return UniquePathsDynamicProgramming(m, n);
        return UniquePathsRecursion(m, n);
    }

    private static int UniquePathsMaths(int m, int n)
    {
        long totalPlaces = m + n - 2;
        long minPlaces = Math.Min(m - 1, n - 1);
        long result = 1;

        for (int i = 0; i < minPlaces; i++)
        {
            result = result * (totalPlaces - i) / (i + 1);
        }

        return (int)result;
    }

    private static int UniquePathsDynamicProgramming(int m, int n)
    {
        int[][] d = new int[m][];

        for (int i = 0; i < m; ++i)
        {
            d[i] = new int[n];

            for (int j = 0; j < n; ++j)
            {
                d[i][j] = 1;
            }
        }

        for (int col = 1; col < m; ++col)
        {
            for (int row = 1; row < n; ++row)
            {
                d[col][row] = d[col - 1][row] + d[col][row - 1];
            }
        }

        return d[m - 1][n - 1];
    }

    private static int UniquePathsRecursion(int m, int n)
    {
        if (m == 1 || n == 1)
        {
            return 1;
        }

        return UniquePathsRecursion(m - 1, n) + UniquePathsRecursion(m, n - 1);
    }
}