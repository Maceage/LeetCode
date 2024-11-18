using System;

namespace LeetCode.Problems;

public class TicketingSystem
{
    public enum AllocationMethod
    {
        MiddleOutwards,
        FrontToBackRow
    }

    private static readonly bool[,] _tickets = new bool[5, 10];

    private static readonly int[][] directions = [[-1, 0], [1, 0], [0, -1], [-1, 0]];

    private static readonly Dictionary<int, char> _rowDictionary = new()
    {
        { 0, 'A' },
        { 1, 'B' },
        { 2, 'C' },
        { 3, 'D' },
        { 4, 'E' }
    };

    public string GetNextTicket(AllocationMethod allocationMethod)
    {
        string result = string.Empty;

        int row = GetInitialRow(allocationMethod);
        int column = GetInitialColumn(allocationMethod);

        while (_tickets[row, column])
        {
            int[] direction = GetDirection(allocationMethod);

            row += direction[0];
            column += direction[1];
        }

        char rowChar = _rowDictionary[row];

        result = string.Format($"{rowChar}{column}"); ;

        return result;
    }

    private static int[] GetDirection(AllocationMethod allocationMethod)
    {
        int[] direction = [];

        Random random = new Random();

        switch (allocationMethod)
        {
            case AllocationMethod.MiddleOutwards:
                // Logic for ensuring direction goes from middle
                int nextSeatDirection = random.Next(0, 3);
                direction = directions[nextSeatDirection];
                break;
            case AllocationMethod.FrontToBackRow:
                //int nextSeatDirection = 
                // Logic for ensuring direction is downwards
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(allocationMethod), allocationMethod, null);
        }

        return direction;
    }

    private static int GetInitialRow(AllocationMethod allocationMethod)
    {
        switch (allocationMethod)
        {
            case AllocationMethod.MiddleOutwards:
                return 2;
            case AllocationMethod.FrontToBackRow:
                return 0;
            default:
                throw new ArgumentOutOfRangeException(nameof(allocationMethod), allocationMethod, null);
        }
    }

    private static int GetInitialColumn(AllocationMethod allocationMethod)
    {
        switch (allocationMethod)
        {
            case AllocationMethod.MiddleOutwards:
            case AllocationMethod.FrontToBackRow:
                return 5;
            default:
                throw new ArgumentOutOfRangeException(nameof(allocationMethod), allocationMethod, null);
        }
    }
}