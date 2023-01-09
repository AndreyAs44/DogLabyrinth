namespace Labyrinth.Scripts.GameLogic;

public struct Coordinate
{
	public int x;
	public int y;

	public static Coordinate right = new(1, 0);
	public static Coordinate left = new(-1, 0);
	public static Coordinate up = new(0, 1);
	public static Coordinate down = new(0, -1);
	public Coordinate(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public static Coordinate operator +(Coordinate a, Coordinate b)
	{
		return new Coordinate(a.x + b.x, a.y + b.y);
	}

	public static Coordinate operator -(Coordinate a, Coordinate b)
	{
		return new Coordinate(a.x - b.x, a.y - b.y);
	}

	public static Coordinate operator *(Coordinate a, Coordinate b)
	{
		return new Coordinate(a.x * b.x, a.y * b.y);
	}

	public static Coordinate operator /(Coordinate a, Coordinate b)
	{
		return new Coordinate(a.x / b.x, a.y / b.y);
	}

	public static bool operator ==(Coordinate a, Coordinate b)
	{
		return a.x == b.x && a.y == b.y;
	}

	public static bool operator !=(Coordinate a, Coordinate b)
	{
		return a.x != b.x || a.y != b.y;
	}

	public override string ToString()
	{
		return $"({x}, {y})";
	}

	public bool Equals(Coordinate other)
	{
		return x == other.x && y == other.y;
	}
	public override bool Equals(object obj)
	{
		return obj is Coordinate other && Equals(other);
	}
	public override int GetHashCode()
	{
		unchecked
		{
			return (x * 397) ^ y;
		}
	}
}