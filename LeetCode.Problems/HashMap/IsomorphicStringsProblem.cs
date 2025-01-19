using System.Text;

namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/isomorphic-strings
/// </summary>
public class IsomorphicStringsProblem
{
    public bool IsIsomorphic(string s, string t)
    {
        return IsIsomorphicWithFirstOccurenceTransformation(s, t);
        return IsIsomorphicWithCharacterMappingWithDictionary(s, t);
    }

    private static bool IsIsomorphicWithFirstOccurenceTransformation(string s, string t)
    {
        return TransformString(s).Equals(TransformString(t));
    }

    private static string TransformString(string s)
    {
        Dictionary<char, int> indexMapping = new Dictionary<char, int>();

        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];

            indexMapping.TryAdd(c1, i);

            stringBuilder.Append(indexMapping[c1].ToString());
            stringBuilder.Append(' ');
        }

        return stringBuilder.ToString();
    }

    private static bool IsIsomorphicWithCharacterMappingWithDictionary(string s, string t)
    {
        int[] mappingsSToT = new int[256];
        System.Array.Fill(mappingsSToT, -1);

        int[] mappingsTToS = new int[256];
        System.Array.Fill(mappingsTToS, -1);

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (mappingsSToT[c1] == -1 && mappingsTToS[c2] == -1)
            {
                mappingsSToT[c1] = c2;
                mappingsTToS[c2] = c1;
            }
            else if (!(mappingsSToT[c1] == c2 && mappingsTToS[c2] == c1))
            {
                return false;
            }
        }

        return true;
    }
}