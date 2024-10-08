using FluentAssertions;
using LeetCode.Problems.Graph;

namespace LeetCode.Tests.Graph;

public class KeysAndRoomsProblemTests
{
    [Fact]
    public void CanVisitAllRooms_TestCase_1()
    {
        // Arrange
        IList<IList<int>> rooms = [[1], [2], [3], []];

        KeysAndRoomsProblem keysAndRoomsProblem = new KeysAndRoomsProblem();

        // Act
        bool actual = keysAndRoomsProblem.CanVisitAllRooms(rooms);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void CanVisitAllRooms_TestCase_2()
    {
        // Arrange
        IList<IList<int>> rooms = [[1, 3], [3, 0, 1], [2], [0]];

        KeysAndRoomsProblem keysAndRoomsProblem = new KeysAndRoomsProblem();

        // Act
        bool actual = keysAndRoomsProblem.CanVisitAllRooms(rooms);

        // Assert
        actual.Should().BeFalse();
    }
}