using System;

namespace Labyrinth.Scripts.GameLevels.LevelTiles
{
	public class Tile
	{
		public Tile(char symbol, bool isWalkable, ConsoleColor consoleColor)
		{
			Symbol = symbol;
			IsWalkable = isWalkable;
			ConsoleColor = consoleColor;
			Tiles.AllTiles.Add(this);
		}
		public char Symbol { get; }
		public bool IsWalkable { get; }
		public ConsoleColor ConsoleColor { get; }
		
		public override string ToString()
		{
			return $"Symbol: {Symbol}, IsWalkable: {IsWalkable}, ConsoleColor: {ConsoleColor}";
		}
	}
}