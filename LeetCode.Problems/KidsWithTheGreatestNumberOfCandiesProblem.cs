namespace LeetCode.Problems;

public class KidsWithTheGreatestNumberOfCandiesProblem
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> indices = new List<bool>();

        // Get the highest number of candies
        int highestCandies = 0;

        foreach (var candy in candies)
        {
            if (candy >= highestCandies)
            {
                highestCandies = candy;
            }
        }

        // Get maximum calculated number of candies
        foreach (var candy in candies)
        {
            int total = candy + extraCandies;

            bool isGreater = total >= highestCandies;

            indices.Add(isGreater);
        }

        return indices;
    }
}