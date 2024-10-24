namespace LeetCode.Problems.Stack;

/// <summary>
/// https://leetcode.com/problems/decode-string
/// </summary>
public class DecodeStringProblem
{
    public string DecodeString(string s)
    {
        Stack<char> charStack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == ']')
            {
                List<char> decodedString = new List<char>();

                while (charStack.Peek() != '[')
                {
                    char currentChar = charStack.Pop();

                    decodedString.Add(currentChar);
                }

                // Pop [ from the stack
                charStack.Pop();

                int baseTen = 1;
                int k = 0;

                // Get the number k
                while ((charStack.Count > 0) && (char.IsDigit(charStack.Peek())))
                {
                    k += (charStack.Pop() - '0') * baseTen;
                    baseTen *= 10;
                }

                // Decode k[decodedString] by pushing decodedString k times into stack
                while (k != 0)
                {
                    for (int j = decodedString.Count - 1; j >= 0; j--)
                    {
                        charStack.Push(decodedString[j]);
                    }

                    k--;
                }
            }
            else
            {
                charStack.Push(c);
            }
        }

        // Get result from the stack
        char[] resultChars = new char[charStack.Count];

        for (int i = charStack.Count - 1; i >= 0; i--)
        {
            resultChars[i] = charStack.Pop();
        }

        return new string(resultChars);
    }
}