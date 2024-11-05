using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class AddBinaryProblemTests
{
    [Fact]
    public void AddBinary_TestCase_1()
    {
        // Arrange
        string a = "11";
        string b = "1";

        AddBinaryProblem addBinaryProblem = new AddBinaryProblem();

        // Act
        string actual = addBinaryProblem.AddBinary(a, b);

        // Assert
        actual.Should().Be("100");
    }

    [Fact]
    public void AddBinary_TestCase_2()
    {
        // Arrange
        string a = "1010";
        string b = "1011";

        AddBinaryProblem addBinaryProblem = new AddBinaryProblem();

        // Act
        string actual = addBinaryProblem.AddBinary(a, b);

        // Assert
        actual.Should().Be("10101");
    }

    [Fact]
    public void AddBinary_TestCase_3()
    {
        // Arrange
        string a = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
        string b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";

        AddBinaryProblem addBinaryProblem = new AddBinaryProblem();

        // Act
        string actual = addBinaryProblem.AddBinary(a, b);

        // Assert
        actual.Should().Be("110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000");
    }
}