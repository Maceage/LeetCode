namespace LeetCode.Problems.Stack;

/// <summary>
/// https://leetcode.com/problems/valid-parentheses
/// </summary>
public class ValidParenthesesProblem
{
    private readonly Stack<char> _charStack = new();

    private readonly Dictionary<char, char> _closingBracketsDictionary = new()
    {
        {')', '('},
        {'}', '{'},
        {']', '['}
    };

    public bool IsValid(string s)
    {
        foreach (var c in s.ToCharArray())
        {
            if (_closingBracketsDictionary.TryGetValue(c, out var openingBracket))
            {
                char lastChar = _charStack.Count <= 0 ? '#' : _charStack.Peek();

                if (lastChar != openingBracket)
                {
                    return false;
                }

                _charStack.Pop();
            }
            else
            {
                _charStack.Push(c);
            }
        }

        return _charStack.Count <= 0;
    }
}