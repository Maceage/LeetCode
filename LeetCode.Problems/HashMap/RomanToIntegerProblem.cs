namespace LeetCode.Problems.HashMap;

public class RomanToIntegerProblem
{
    private readonly Dictionary<char, int> romanNumeralsDictionary = new()
    {
        {'I', 1 },
        {'V', 5 },
        {'X', 10 },
        {'L', 50 },
        {'C', 100 },
        {'D', 500 },
        {'M', 1000 }
    };

    public int RomanToInt(string s)
    {
        // I can be placed before V (5) and X (10) to make 4 and 9. 
        // X can be placed before L (50) and C (100) to make 40 and 90. 
        // C can be placed before D (500) and M (1000) to make 400 and 900.
        char lastSymbol = s[s.Length - 1];
        int lastValue = romanNumeralsDictionary[lastSymbol];
        int total = lastValue;

        for (int i = s.Length - 2; i >= 0; i--)
        {
            char c = s[i];
            int currentValue = romanNumeralsDictionary[c];

            if (currentValue < lastValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            lastValue = currentValue;
        }

        return total;
    }
}