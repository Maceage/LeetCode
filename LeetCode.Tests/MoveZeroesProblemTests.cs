﻿using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class MoveZeroesProblemTests
{
    [Fact]
    public void MoveZeroes_TestCase_1()
    {
        // Arrange
        int[] nums = [0, 1, 0, 3, 12];
        int[] expected = [1, 3, 12, 0, 0];

        MoveZeroesProblem moveZeroesProblem = new MoveZeroesProblem();

        // Act
        moveZeroesProblem.MoveZeroes(nums);

        // Assert
        nums.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
    }

    [Fact]
    public void MoveZeroes_TestCase_2()
    {
        // Arrange
        int[] nums = [1];
        int[] expected = [1];

        MoveZeroesProblem moveZeroesProblem = new MoveZeroesProblem();

        // Act
        moveZeroesProblem.MoveZeroes(nums);

        // Assert
        nums.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
    }
}