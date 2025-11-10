public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private Direction _currentDirection;
    private int _x;
    private int _y;

    public RobotSimulator(Direction direction, int x, int y)
    {
        _currentDirection = direction;
        _x = x;
        _y = y;
    }

    public Direction Direction => _currentDirection;
    public int X => _x;
    public int Y => _y;

    public void Move(string instructions)
    {
        foreach (char instruction in instructions)
        {
            switch (instruction)
            {
                case 'R': // Turn Right
                    TurnRight();
                    break;
                case 'L': // Turn Left
                    TurnLeft();
                    break;
                case 'A': // Advance
                    Advance();
                    break;
                default:
                    throw new ArgumentException("Invalid instruction: " + instruction);
            }
        }
    }

    private void TurnRight()
    {
        _currentDirection = _currentDirection switch
        {
            Direction.North => Direction.East,
            Direction.East => Direction.South,
            Direction.South => Direction.West,
            Direction.West => Direction.North,
            _ => throw new ArgumentOutOfRangeException() // Should not happen with valid enum values
        };
    }

    private void TurnLeft()
    {
        _currentDirection = _currentDirection switch
        {
            Direction.North => Direction.West,
            Direction.West => Direction.South,
            Direction.South => Direction.East,
            Direction.East => Direction.North,
            _ => throw new ArgumentOutOfRangeException() // Should not happen
        };
    }

    private void Advance()
    {
        switch (_currentDirection)
        {
            case Direction.North:
                _y++;
                break;
            case Direction.East:
                _x++;
                break;
            case Direction.South:
                _y--;
                break;
            case Direction.West:
                _x--;
                break;
        }
    }
}