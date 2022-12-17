using Xunit;
using AdventOfCode2015.Day02;

namespace AdventOfCode2015.Tests;

public class Day02Tests
{
    public class PartOneTests
    {
        [Theory]
        [InlineData("2x3x4", 58)]
        [InlineData("1x1x10", 43)]
        public void WrappingPaperForOnePresent(string dimensions, int expected)
        {
            int result = Puzzle.PaperForPresent(dimensions);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WrappingPaperForAllPresents()
        {
            string[] listOfPresentDimensions = new string[2];
            listOfPresentDimensions[0] = "2x3x4";
            listOfPresentDimensions[1] = "1x1x10";
            int expected = 101;

            int result = Puzzle.PaperForMultiplePresents(listOfPresentDimensions);

            Assert.Equal(expected, result);
        }
    }

    public class PartTwoTests
    {
        [Theory]
        [InlineData("2x3x4", 34)]
        [InlineData("1x1x10", 14)]
        public void RibbonForOnePresent(string dimensions, int expected)
        {
            int result = Puzzle.RibbonForPresent(dimensions);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void RibbonForAllPresents()
        {
            string[] listOfPresentDimensions = new string[2];
            listOfPresentDimensions[0] = "2x3x4";
            listOfPresentDimensions[1] = "1x1x10";
            int expected = 48;

            int result = Puzzle.RibbonForMultiplePresents(listOfPresentDimensions);

            Assert.Equal(expected, result);
        }
    }
}
