namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/minimum-index-sum-of-two-lists
/// </summary>
public class MinimumIndexSumOfTwoListsProblem
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        return FindRestaurantWithHashmap(list1, list2);
        return FindRestaurantOriginal(list1, list2);
    }

    private static string[] FindRestaurantWithHashmap(string[] list1, string[] list2)
    {
        Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();

        for (int i = 0; i < list1.Length; i++)
        {
            for (int j = 0; j < list2.Length; j++)
            {
                if (list1[i].Equals(list2[j]))
                {
                    int sum = i + j;

                    if (!map.ContainsKey(sum))
                    {
                        map.Add(sum, []);
                    }

                    map[sum].Add(list1[i]);
                }
            }
        }

        int minIndexSum = int.MaxValue;

        foreach (int mapKey in map.Keys)
        {
            minIndexSum = Math.Min(minIndexSum, mapKey);
        }

        return map[minIndexSum].ToArray();
    }

    private static string[] FindRestaurantOriginal(string[] list1, string[] list2)
    {
        if (list1 == null || list2 == null)
        {
            return [];
        }

        int indexSum = int.MaxValue;
        List<string> wordList = new List<string>();

        Dictionary<string, int> list1Indexes = GetWordIndexesDictionary(list1);
        Dictionary<string, int> list2Indexes = GetWordIndexesDictionary(list2);

        foreach (string key in list1Indexes.Keys)
        {
            if (list1Indexes.TryGetValue(key, out var list1Index) && (list2Indexes.TryGetValue(key, out var list2Index)))
            {
                int sum = list1Index + list2Index;

                if (sum < indexSum)
                {
                    wordList.Clear();
                    wordList.Add(key);

                    indexSum = sum;
                }
                else if (sum == indexSum)
                {
                    wordList.Add(key);
                }
            }
        }

        return wordList.ToArray();
    }

    private static Dictionary<string, int> GetWordIndexesDictionary(string[] list)
    {
        Dictionary<string, int> wordIndexes = new Dictionary<string, int>();

        for (int i = 0; i < list.Length; i++)
        {
            string word = list[i];

            wordIndexes.Add(word, i);
        }

        return wordIndexes;
    }
}