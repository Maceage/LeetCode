namespace LeetCode.Problems.Array;

public class ReverseVowelsOfAStringProblem
{
    public string ReverseVowels(string s)
    {
        char[] stringChars = s.ToCharArray();

        int leftIndex = 0;
        int rightIndex = s.Length - 1;

        while (leftIndex < rightIndex)
        {
            char leftChar = stringChars[leftIndex];
            bool leftCharIsVowel = IsVowel(leftChar);

            if (!leftCharIsVowel)
            {
                leftIndex++;
            }

            char rightChar = stringChars[rightIndex];
            bool rightCharIsVowel = IsVowel(rightChar);

            if (!rightCharIsVowel)
            {
                rightIndex--;
            }

            if (leftCharIsVowel && rightCharIsVowel)
            {
                stringChars[rightIndex] = leftChar;
                stringChars[leftIndex] = rightChar;

                leftIndex++;
                rightIndex--;
            }
        }

        return new string(stringChars);
    }

    private static bool IsVowel(char c)
    {
        return ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u') ||
                (c == 'A') || (c == 'E') || (c == 'I') || (c == 'O') || (c == 'U'));
    }
}