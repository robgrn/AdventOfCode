namespace AdventOfCode2015;

class Program
{
    static void Main(string[] args)
    {
        string input = File.ReadAllText("2015/AdventOfCode2015/Day04/input04.txt");
        Day04.Puzzle puzzle = new Day04.Puzzle(input);
        int result = puzzle.PartTwo();

        Console.WriteLine(result);
    }
}
