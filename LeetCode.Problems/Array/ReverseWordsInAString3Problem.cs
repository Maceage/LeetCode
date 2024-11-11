using System.Text;

namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/reverse-words-in-a-string-iii/
/// </summary>
public class ReverseWordsInAString3Problem
{
    public string ReverseWords(string s)
    {
        return ReverseWordsTwoPointers(s);
        return ReverseWordsTraverseReverseEachCharacter(s);
        return ReverseWordsOriginal(s);
    }

    private static string ReverseWordsTwoPointers(string s)
    {
        int lastSpaceIndex = -1;
        char[] charArray = s.ToCharArray();
        int len = s.Length;

        for (int i = 0; i <= len; i++)
        {
            if (i == len || charArray[i] == ' ')
            {
                int startIndex = lastSpaceIndex + 1;
                int endIndex = i - 1;

                while (startIndex < endIndex)
                {
                    char temp = charArray[startIndex];
                    charArray[startIndex] = charArray[endIndex];
                    charArray[endIndex] = temp;
                    startIndex++;
                    endIndex--;
                }

                lastSpaceIndex = i;
            }
        }

        return new string(charArray);
    }

    private static string ReverseWordsTraverseReverseEachCharacter(string s)
    {
        StringBuilder result = new StringBuilder();

        int lastSpaceIndex = -1;

        for (int strIndex = 0; strIndex < s.Length; strIndex++)
        {
            if ((strIndex == s.Length - 1) || s[strIndex] == ' ')
            {
                int reverseStrIndex = (strIndex == s.Length - 1) ? strIndex : strIndex - 1;

                for (; reverseStrIndex > lastSpaceIndex; reverseStrIndex--)
                {
                    result.Append(s[reverseStrIndex]);
                }

                if (strIndex != s.Length - 1)
                {
                    result.Append(' ');
                }

                lastSpaceIndex = strIndex;
            }
        }

        return result.ToString();
    }

    private static string ReverseWordsOriginal(string s)
    {
        Queue<string> wordQueue = new();

        StringBuilder result = new StringBuilder();
        StringBuilder wordStringBuilder = new StringBuilder();

        // Iterate through characters
        for (int i = 0; i < s.Length + 1; i++)
        {
            char charAt = i < s.Length ? s[i] : ' ';

            // Check if the character is a space
            if (charAt == ' ')
            {
                // Add word string to stack and clear word string variable
                wordQueue.Enqueue(wordStringBuilder.ToString());

                wordStringBuilder.Clear();
            }
            else
            {
                // Add the character to a word string variable if not a space
                wordStringBuilder.Append(charAt);
            }
        }

        // Unwind the word stack and add to result
        do
        {
            string word = wordQueue.Dequeue();

            string reversedWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            result.Append(reversedWord);

            wordQueue.TryPeek(out word);

            if (!string.IsNullOrEmpty(word))
            {
                result.Append(' ');
            }
        }
        while (wordQueue.Count > 0);

        return result.ToString();
    }
}