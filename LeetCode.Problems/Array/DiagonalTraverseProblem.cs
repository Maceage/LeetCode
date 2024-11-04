namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/diagonal-traverse
/// </summary>
public class DiagonalTraverseProblem
{
    public int[] FindDiagonalOrder(int[][] matrix)
    {
        return FindDiagonalOrderSimulation(matrix);
        return FindDiagonalOrderIterationAndReversal(matrix);
    }

    private static int[] FindDiagonalOrderSimulation(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0)
        {
            return [];
        }

        int n = matrix.Length;
        int m = matrix[0].Length;

        int row = 0;
        int col = 0;

        int direction = 1;

        int[] result = new int[n * m];
        int r = 0;

        while (row < n && col < m)
        {
            result[r++] = matrix[row][col];

            int newRow = row + (direction == 1 ? -1 : 1);
            int newCol = col + (direction == 1 ? 1 : -1);

            if (newRow < 0 || newRow == n || newCol < 0 || newCol == m)
            {
                if (direction == 1)
                {
                    row += (col == m - 1 ? 1 : 0);
                    col += (col < m - 1 ? 1 : 0);
                }
                else
                {
                    col += (row == n - 1 ? 1 : 0);
                    row += (row < n - 1 ? 1 : 0);
                }

                direction = 1 - direction;
            }
            else
            {
                row = newRow;
                col = newCol;
            }
        }

        return result;
    }

    private static int[] FindDiagonalOrderIterationAndReversal(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0)
        {
            return [];
        }

        int n = matrix.Length;
        int m = matrix[0].Length;

        int[] result = new int[n * m];
        int k = 0;

        List<int> intermediate = new List<int>();

        for (int d = 0; d < n + m - 1; d++)
        {
            intermediate.Clear();

            int row = d < m ? 0 : d - m + 1;
            int col = d < m ? d : m - 1;

            while (row < n && col > -1)
            {
                intermediate.Add(matrix[row][col]);

                row++;
                col--;
            }

            if (d % 2 == 0)
            {
                intermediate.Reverse();
            }

            foreach (var t in intermediate)
            {
                result[k++] = t;
            }
        }

        return result;
    }
}