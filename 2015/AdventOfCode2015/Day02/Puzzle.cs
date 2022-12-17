namespace AdventOfCode2015.Day02;

public class Puzzle
{
    public static void PartOne(string inputPath)
    {
        int result = PaperForMultiplePresents(File.ReadAllLines(inputPath));
        Console.WriteLine(result);
    }

    public static void PartTwo(string inputPath)
    {
        int result = RibbonForMultiplePresents(File.ReadAllLines(inputPath));
        Console.WriteLine(result);
    }

    /// <summary>
    /// Calculates the amount of paper needed for a single present when given the dimensions in the form "lxwxh".
    /// </summary>
    public static int PaperForPresent(string dimensions)
    {
        string[] parsedDimensions = dimensions.Split('x');
        int.TryParse(parsedDimensions[0], out int length);
        int.TryParse(parsedDimensions[1], out int width);
        int.TryParse(parsedDimensions[2], out int height);

        int area1 = length * width;
        int area2 = width * height;
        int area3 = length * height;

        return (2 * area1) + (2 * area2) + (2 * area3) + Math.Min(area1, Math.Min(area2, area3));
    }

    /// <summary>
    /// Calculates the amount of paper needed for a list of presents.
    /// </summary>
    public static int PaperForMultiplePresents(IEnumerable<string> listOfDimensions)
    {
        int paperAmount = 0;
        foreach (string line in listOfDimensions)
            paperAmount += PaperForPresent(line);

        return paperAmount;
    }

    public static int RibbonForPresent(string dimensions)
    {
        string[] parsedDimensions = dimensions.Split('x');
        int[] cleanedDimensions = new int[3];

        int.TryParse(parsedDimensions[0], out cleanedDimensions[0]);
        int.TryParse(parsedDimensions[1], out cleanedDimensions[1]);
        int.TryParse(parsedDimensions[2], out cleanedDimensions[2]);

        Array.Sort(cleanedDimensions);
        int perimeter = cleanedDimensions[0] + cleanedDimensions[0] + cleanedDimensions[1] + cleanedDimensions[1];

        return perimeter + (cleanedDimensions[0] * cleanedDimensions[1] * cleanedDimensions[2]);
    }

    public static int RibbonForMultiplePresents(IEnumerable<string> presentList)
    {
        int ribbonAmount = 0;
        foreach (string line in presentList)
        {
            ribbonAmount += RibbonForPresent(line);
        }

        return ribbonAmount;
    }
}
