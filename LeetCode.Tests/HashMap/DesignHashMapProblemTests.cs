using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class DesignHashMapProblemTests
{
    [Fact]
    public void MyHashMap_TestCase_1()
    {
        // Arrange
        DesignHashMapProblem.MyHashMap myHashMap = new DesignHashMapProblem.MyHashMap();

        // Act/Assert
        myHashMap.Put(1,1);
        myHashMap.Put(2,2);
        myHashMap.Get(1).Should().Be(1);
        myHashMap.Get(3).Should().Be(-1);
        myHashMap.Put(2,1);
        myHashMap.Get(2).Should().Be(1);
        myHashMap.Remove(2);
        myHashMap.Get(2).Should().Be(-1);
    }
}