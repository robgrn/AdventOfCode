namespace AdventOfCode2015.Day01;

public class Puzzle
{
    public static int PartOne(string input)
    {
        int floor = 0;

        foreach (char ch in input)
        {
            if (ch == '(')
                floor++;
            else if (ch == ')')
                floor--;
        }

        return floor;
    }

    public static int PartTwo(string input)
    {
        int floor = 0;
        int position = 0;

        foreach (char ch in input)
        {
            position++;
            if (ch == '(')
                floor++;
            else if (ch == ')')
                floor--;
            
            if (floor == -1)
                break;
        }

        return position;
    }
}
