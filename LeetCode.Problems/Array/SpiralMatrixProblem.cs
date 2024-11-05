namespace LeetCode.Problems.Array;

public class SpiralMatrixProblem
{
    private readonly int[] _rightDirection = [1, 0];
    private readonly int[] _downDirection = [0, 1];
    private readonly int[] _leftDirection = [-1, 0];
    private readonly int[] _upDirection = [0, -1];

    public IList<int> SpiralOrder(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0)
        {
            return [];
        }

        int rowCount = matrix.Length;
        int colCount = matrix[0].Length;

        int row = 0;
        int col = 0;

        int rowTopBoundary = -1;
        int rowBottomBoundary = rowCount;

        int colLeftBoundary = -1;
        int colRightBoundary = colCount;

        int[] direction = _rightDirection;

        List<int> result = new List<int>(rowCount * colCount);

        do
        {
            int currentValue = matrix[row][col];

            result.Add(currentValue);

            col += direction[0];
            row += direction[1];

            if (col >= colRightBoundary)
            {
                // Hit the right boundary
                direction = _downDirection;

                col--;

                rowTopBoundary++;

                col += direction[0];
                row += direction[1];
            }
            else if (row >= rowBottomBoundary)
            {
                // Hit the bottom boundary
                direction = _leftDirection;

                row--;
                colRightBoundary--;

                col += direction[0];
                row += direction[1];
            }
            else if (col <= colLeftBoundary)
            {
                // Hit the left boundary
                direction = _upDirection;

                col++;
                rowBottomBoundary--;

                col += direction[0];
                row += direction[1];
            }
            else if (row <= rowTopBoundary)
            {
                // Hit the top boundary
                direction = _rightDirection;

                row++;
                colLeftBoundary++;

                col += direction[0];
                row += direction[1];
            }
        }
        while ((row > rowTopBoundary) && (row < rowBottomBoundary) && (col > colLeftBoundary) && (col < colRightBoundary));

        return result;
    }
}