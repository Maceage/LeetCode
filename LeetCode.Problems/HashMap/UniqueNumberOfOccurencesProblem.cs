namespace LeetCode.Problems.HashMap;

public class UniqueNumberOfOccurrencesProblem
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> occurrencesDictionary = new Dictionary<int, int>();

        foreach (int i in arr)
        {
            if (!occurrencesDictionary.TryAdd(i, 1))
            {
                occurrencesDictionary[i]++;
            }
        }

        Dictionary<int, int> occurrencesCountDictionary = new Dictionary<int, int>();

        foreach (var keyValuePair in occurrencesDictionary)
        {
            int count = keyValuePair.Value;

            if (!occurrencesCountDictionary.TryAdd(count, 1))
            {
                occurrencesCountDictionary[count]++;
            }
        }

        return (occurrencesDictionary.Count == occurrencesCountDictionary.Count);
    }
}