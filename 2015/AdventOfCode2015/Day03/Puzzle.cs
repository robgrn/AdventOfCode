namespace AdventOfCode2015.Day03;

public class Puzzle
{
    private string input;

    public Puzzle(string _input)
    {
        input = _input;
    }

    public int PartOne()
    {
        Coordinate currentPosition = new Coordinate(0, 0);
        HashSet<Coordinate> uniqueHouseVisits = new HashSet<Coordinate>() { currentPosition };

        foreach (char movement in input)
        {
            Coordinate newPosition = nextMove(movement, currentPosition);
            uniqueHouseVisits.Add(newPosition);
            currentPosition = newPosition;
        }

        return uniqueHouseVisits.Count;
    }

    public int PartTwo()
    {
        Coordinate santaPosition = new Coordinate(0, 0);
        Coordinate roboSantaPosition = santaPosition;
        HashSet<Coordinate> uniqueHouseVisits = new HashSet<Coordinate>() { santaPosition };
        bool santaNext = true;

        foreach (char movement in input)
        {
            Coordinate newPosition;
            if (santaNext)
            {
                newPosition = nextMove(movement, santaPosition);
                uniqueHouseVisits.Add(newPosition);
                santaPosition = newPosition;
                santaNext = false;
            }
            else
            {
                newPosition = nextMove(movement, roboSantaPosition);
                uniqueHouseVisits.Add(newPosition);
                roboSantaPosition = newPosition;
                santaNext = true;
            }
        }

        return uniqueHouseVisits.Count;
    }

    private Coordinate nextMove(char movement, Coordinate position)
    {
        Coordinate newPosition;
        switch (movement)
        {
            case '>':
                newPosition = new Coordinate(position.X + 1, position.Y);
                break;
            case 'v':
                newPosition = new Coordinate(position.X, position.Y + 1);
                break;
            case '<':
                newPosition = new Coordinate(position.X - 1, position.Y);
                break;
            case '^':
                newPosition = new Coordinate(position.X, position.Y - 1);
                break;
            default:
                newPosition = position;
                break;
        }

        return newPosition;
    }

    class Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Coordinate c = (Coordinate) obj;
                return (X == c.X) && (Y == c.Y);
            }
        }

        public override int GetHashCode()
        {
            // Cantor pairing function but using absolute values so negative coordinates don't result in a 0 hash code.
            // Not perfect because negative values made positive will have collisions with the same positive values but
            // it'll do for this.
            int absX = Math.Abs(X);
            int absY = Math.Abs(Y);

            return ((absX + absY) * (absX + absY + 1) / 2) + absY;
        }
    }
}
