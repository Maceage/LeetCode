namespace LeetCode.Problems;

public class PalindromeNumberProblem
{
    public bool IsPalindrome(int x)
    {
        bool isPalindrome = true;

        string integerString = x.ToString();

        Queue<char> charQueue = new Queue<char>();

        if (integerString.Length > 0)
        {
            foreach (var c in integerString)
            {
                charQueue.Enqueue(c);
            }

            for (int i = integerString.Length - 1; i > 0; i--)
            {
                char arrayChar = integerString[i];
                char queueChar = charQueue.Dequeue();

                var matchesChar = (arrayChar == queueChar);

                if (!matchesChar)
                {
                    isPalindrome = false;
                    break;
                }
            }
        }

        return isPalindrome;
    }
}