using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class TicketingSystemTests
{
    [Fact]
    public void GetNextTicket_TestCase_1()
    {
        // Arrange
        TicketingSystem ticketingSystem = new TicketingSystem();

        // Act
        string actual = ticketingSystem.GetNextTicket(TicketingSystem.AllocationMethod.MiddleOutwards);

        // Assert
        actual.Should().Be("C5");
    }

    [Fact]
    public void GetNextTicket_TestCase_2()
    {
        // Arrange
        TicketingSystem ticketingSystem = new TicketingSystem();

        // Act
        string firstSeat = ticketingSystem.GetNextTicket(TicketingSystem.AllocationMethod.FrontToBackRow);
        string nextSeat = ticketingSystem.GetNextTicket(TicketingSystem.AllocationMethod.FrontToBackRow);

        // Assert
        firstSeat.Should().Be("A5");
        nextSeat.Should().Be("A4");
    }
}