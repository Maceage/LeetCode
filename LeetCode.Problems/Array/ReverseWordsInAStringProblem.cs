namespace LeetCode.Problems.Array;

/// <summary>
/// https://leetcode.com/problems/reverse-words-in-a-string
/// </summary>
public class ReverseWordsInAStringProblem
{
    private readonly Stack<string> _wordStack = new();

    public string ReverseWords(string s)
    {
        string result = null;

        string wordString = null;

        // Iterate through characters
        for (int i = 0; i < s.Length + 1; i++)
        {
            char charAt;

            if (i < s.Length)
            {
                charAt = s[i];
            }
            else
            {
                charAt = ' ';
            }

            // Check if the character is a space
            if (charAt == ' ')
            {
                // Add word string to stack and clear word string variable
                if (!string.IsNullOrEmpty(wordString))
                {
                    _wordStack.Push(wordString);

                    wordString = null;
                }
            }
            else
            {
                // Add the character to a word string variable if not a space
                wordString += charAt;
            }
        }

        // Unwind the word stack and add to result
        do
        {
            string word = _wordStack.Pop();

            if (!string.IsNullOrEmpty(word))
            {
                result += word;
            }

            _wordStack.TryPeek(out word);

            if (!string.IsNullOrEmpty(word))
            {
                result += ' ';
            }
        }
        while (_wordStack.Count > 0);

        return result;
    }
}