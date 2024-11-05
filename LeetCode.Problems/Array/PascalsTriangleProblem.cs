namespace LeetCode.Problems.Array;

public class PascalsTriangleProblem
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows <= 0)
        {
            return [];
        }

        IList<IList<int>> triangle = new List<IList<int>>();

        triangle.Add([1]);

        for (int rowNum = 1; rowNum < numRows; rowNum++)
        {
            List<int> row = new List<int>();

            List<int> previousRow = (List<int>)triangle[rowNum - 1];

            row.Add(1);

            for (int j = 1; j < rowNum; j++)
            {
                row.Add(previousRow[j - 1] + previousRow[j]);
            }

            row.Add(1);

            triangle.Add(row);
        }

        return triangle;
    }
}