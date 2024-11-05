using System.Numerics;
using System.Text;

namespace LeetCode.Problems.Array;

public class AddBinaryProblem
{
    public string AddBinary(string a, string b)
    {
        return AddBinaryBitManipulation(a, b);
        return AddBinaryBitByBitManipulation(a, b);
        return AddBinaryBuiltIn(a, b);
    }

    private static string AddBinaryBitManipulation(string a, string b)
    {
        BigInteger x = ConvertBinaryToBigInteger(a);
        BigInteger y = ConvertBinaryToBigInteger(b);
        BigInteger zero = BigInteger.Zero;

        while (y != zero)
        {
            BigInteger carry = (x & y) << 1;
            x ^= y;
            y = carry;
        }

        return BigIntegerToBinaryString(x);
    }

    private static BigInteger ConvertBinaryToBigInteger(string binary)
    {
        BigInteger result = 0;

        foreach (char c in binary)
        {
            result = result * 2 + (c - '0');
        }

        return result;
    }

    private static string BigIntegerToBinaryString(BigInteger number)
    {
        if (number == 0)
        {
            return "0";
        }

        string binary = "";

        while (number > 0)
        {
            binary = ((number & 1) == 1 ? "1" : "0") + binary;
            number >>= 1;
        }

        return binary;
    }

    private static string AddBinaryBitByBitManipulation(string a, string b)
    {
        int n = a.Length;
        int m = b.Length;

        if (n < m)
        {
            return AddBinaryBitByBitManipulation(b, a);
        }

        StringBuilder stringBuilder = new StringBuilder();

        int carry = 0;
        int j = m - 1;

        for (int i = n - 1; i >= 0; --i)
        {
            if (a[i] == '1')
            {
                ++carry;
            }

            if (j > -1 && b[j--] == '1')
            {
                ++carry;
            }

            stringBuilder.Append((carry % 2).ToString());
            carry /= 2;
        }

        if (carry == 1)
        {
            stringBuilder.Append('1');
        }

        char[] charArray = stringBuilder.ToString().ToCharArray();

        System.Array.Reverse(charArray);

        return new string(charArray);
    }

    private static string AddBinaryBuiltIn(string a, string b)
    {
        int aNum = Convert.ToInt32(a, 2);
        int bNum = Convert.ToInt32(b, 2);

        int result = aNum + bNum;

        return Convert.ToString(result, 2);
    }
}