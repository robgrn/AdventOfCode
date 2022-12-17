using Xunit;
using AdventOfCode2015.Day03;

namespace AdventOfCode2015.Tests;

public class Day03Tests
{
    public class PartOneTests
    {
        [Theory]
        [InlineData(">", 2)]
        [InlineData("^>v<", 4)]
        [InlineData("^v^v^v^v^v", 2)]
        [InlineData(">>>>>>>>>><<<<<<<<<<v", 12)]
        public void UniqueHousesVisited(string movements, int uniqueVisits)
        {
            Puzzle puzzle = new Puzzle(movements);
            int result = puzzle.PartOne();

            Assert.Equal(uniqueVisits, result);
        }
    }

    public class PartTwoTests
    {
        [Theory]
        [InlineData("^v", 3)]
        [InlineData("^>v<", 3)]
        [InlineData("^v^v^v^v^v", 11)]
        public void UniqueHousesVisitedWithRoboSanta(string movements, int uniqueVisits)
        {
            Puzzle puzzle = new Puzzle(movements);
            int result = puzzle.PartTwo();

            Assert.Equal(uniqueVisits, result);
        }
    }
}
