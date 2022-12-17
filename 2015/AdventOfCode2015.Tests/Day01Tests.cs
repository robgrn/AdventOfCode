using Xunit;
using AdventOfCode2015.Day01;

namespace AdventOfCode2015.Tests;

public class Day01Tests
{
    public class PartOneTests
    {
        [Fact]
        public void UpOneFloor_AtFloor1()
        {
            int result = Puzzle.PartOne("(");
            Assert.Equal(1, result);
        }

        [Fact]
        public void DownOneFloor_AtFloorMinus1()
        {
            int result = Puzzle.PartOne(")");
            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData("(())", 0)]
        [InlineData("()()", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("))(((((", 3)]
        [InlineData("())", -1)]
        [InlineData("))(", -1)]
        [InlineData(")))", -3)]
        [InlineData(")())())", -3)]
        public void MoveBetweenMultipleLevels_AtFloor0(string floorChanges, int expectedFloor)
        {
            int result = Puzzle.PartOne(floorChanges);
            Assert.Equal(expectedFloor, result);
        }
    }

    public class PartTwoTests
    {
        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        public void BasementAtPosition1(string floorChanges, int expectedPosition)
        {
            int result = Puzzle.PartTwo(floorChanges);
            Assert.Equal(expectedPosition, result);
        }
    }
}
