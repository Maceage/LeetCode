namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/pascals-triangle-ii/
/// </summary>
public class PascalsTriangle2Problem
{
    public IList<int> GetRow(int rowIndex)
    {
        return GetRowMathCombinatorics(rowIndex);
        return GetRowDynamicProgrammingMemoryEfficient(rowIndex);
        return GetRowDynamicPrograming(rowIndex);
        return GetRowRecursion(rowIndex);
        return GetRowOriginal(rowIndex);
    }

    private static IList<int> GetRowMathCombinatorics(int rowIndex)
    {
        List<int> row = [1];

        for (int k = 1; k <= rowIndex; k++)
        {
            row.Add((int)((row[^1] * (long)(rowIndex - k + 1)) / k));
        }

        return row;
    }

    private static IList<int> GetRowDynamicProgrammingMemoryEfficient(int rowIndex)
    {
        IList<int> row = new int[rowIndex + 1];

        for (int i = 0; i <= rowIndex; i++)
        {
            row[i] = 1;
        }

        for (int i = 1; i < rowIndex; i++)
        {
            for (int j = i; j > 0; j--)
            {
                row[j] += row[j - 1];
            }
        }

        return row;
    }

    private static IList<int> GetRowDynamicPrograming(int rowIndex)
    {
        IList<int> previous = new List<int> { 1 };

        for (int i = 1; i <= rowIndex; i++)
        {
            IList<int> current = new List<int>(new int[i + 1]);

            current[0] = 1;
            current[i] = 1;

            for (int j = 1; j < i; j++)
            {
                current[j] = previous[j - 1] + previous[j];
            }

            previous = current;
        }

        return previous;
    }

    private static IList<int> GetRowRecursion(int rowIndex)
    {
        IList<int> answer = new List<int>();

        for (int i = 0; i <= rowIndex; i++)
        {
            answer.Add(GetNum(rowIndex, i));
        }

        return answer;
    }

    private static int GetNum(int row, int col)
    {
        if (row == 0 || col == 0 | row == col)
        {
            return 1;
        }

        return GetNum(row - 1, col - 1) + GetNum(row - 1, col);
    }

    private static IList<int> GetRowOriginal(int rowIndex)
    {
        if (rowIndex <= 0)
        {
            return [1];
        }

        IList<int> currentRow = [1];

        for (int rowNum = 1; rowNum <= rowIndex; rowNum++)
        {
            IList<int> newRow = new List<int>();

            newRow.Add(1);

            for (int i = 1; i < rowNum; i++)
            {
                newRow.Add(currentRow[i - 1] + currentRow[i]);
            }

            newRow.Add(1);

            currentRow = newRow;
        }

        return currentRow;
    }
}