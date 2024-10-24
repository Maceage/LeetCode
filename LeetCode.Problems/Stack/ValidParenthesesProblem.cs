namespace LeetCode.Problems.Stack;

/// <summary>
/// https://leetcode.com/problems/valid-parentheses
/// </summary>
public class ValidParenthesesProblem
{
    private readonly Stack<char> _charStack = new();

    private readonly Dictionary<char, char> _openingBracketsDictionary = new()
    {
        {'(', ')'},
        {'{', '}'},
        {'[', ']'}
    };

    private readonly Dictionary<char, char> _closingBracketsDictionary = new()
    {
        {')', '('},
        {'}', '{'},
        {']', '['}
    };

    public bool IsValid(string s)
    {
        bool isValid = false;

        foreach (var c in s.ToCharArray())
        {
            if (_openingBracketsDictionary.ContainsKey(c))
            {
                _charStack.Push(c);
            }
            else if (_closingBracketsDictionary.TryGetValue(c, out var openingBracket))
            {
                char lastChar = _charStack.Pop();

                if (lastChar != openingBracket)
                {
                    break;
                }
            }
        }

        if (_charStack.Count == 0)
        {
            isValid = true;
        }

        return isValid;
    }
}