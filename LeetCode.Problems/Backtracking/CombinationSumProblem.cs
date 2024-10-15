namespace LeetCode.Problems.Backtracking;

public class CombinationSumProblem
{
    private readonly IList<IList<int>> _combinations = new List<IList<int>>();

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        if (n > 1)
        {
            Backtrack(0, k, n, 1, []);
        }

        return _combinations;
    }

    private void Backtrack(int currentLevel, int maxLevel, int target, int currentNumber, List<int> currentNumbers)
    {
        if (currentLevel == maxLevel)
        {
            int currentTotal = currentNumbers.Sum();

            if (currentTotal == target)
            {
                _combinations.Add(currentNumbers.ToList());
            }
        }
        else
        {
            for (int i = currentNumber; i <= 9; i++)
            {
                if (!currentNumbers.Contains(i))
                {
                    currentNumbers.Add(i);

                    Backtrack(currentLevel + 1, maxLevel, target, i, currentNumbers);

                    currentNumbers.Remove(i);
                }
            }
        }
    }
}