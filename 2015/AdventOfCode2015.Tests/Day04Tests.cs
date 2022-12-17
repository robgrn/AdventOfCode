using Xunit;
using AdventOfCode2015.Day04;

namespace AdventOfCode2015.Tests;

public class Day04Tests
{
    public class PartOneTests
    {
        [Theory]
        [InlineData("abcdef", 609043)]
        [InlineData("pqrstuv", 1048970)]
        public void FirstHashWithFiveLeadingZeroes(string secretKey, int lowestAnswer)
        {
            Puzzle puzzle = new Puzzle(secretKey);
            int result = puzzle.PartOne();

            Assert.Equal(lowestAnswer, result);
        }
    }
}
