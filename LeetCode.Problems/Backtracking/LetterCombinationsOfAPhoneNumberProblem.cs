using System.Text;

namespace LeetCode.Problems.Backtracking;

/// <summary>
/// https://leetcode.com/problems/letter-combinations-of-a-phone-number
/// </summary>
public class LetterCombinationsOfAPhoneNumberProblem
{
    private readonly Dictionary<char, string> _lettersDictionary = new()
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };

    private readonly List<string> _combinations = new();

    private string _phoneDigits;

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return _combinations;
        }

        _phoneDigits = digits;

        Backtrack(0, new StringBuilder());

        return _combinations;
    }

    private void Backtrack(int index, StringBuilder path)
    {
        if (path.Length == _phoneDigits.Length)
        {
            _combinations.Add(path.ToString());
            return;
        }

        string possibleLetters = _lettersDictionary[_phoneDigits[index]];

        foreach (char letter in possibleLetters)
        {
            path.Append(letter);

            Backtrack(index + 1, path);

            path.Remove(path.Length - 1, 1);
        }
    }
}