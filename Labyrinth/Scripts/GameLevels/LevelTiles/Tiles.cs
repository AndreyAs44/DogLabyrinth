using System;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth.Scripts.GameLevels.LevelTiles
{
	public static class Tiles
	{
		// Tile types
		public static Tile EmptyTile => new Tile(' ', true, ConsoleColor.Black);
		public static Tile PlayerTile => new Tile('@', true, ConsoleColor.Yellow);
		public static Tile GoalTile => new Tile('X', true, ConsoleColor.Green);
		public static Tile WallTile => new Tile('#', false, ConsoleColor.DarkGray);

		// logic
		public static List<Tile> TilesList { get; } = new();

		public static Tile GetTile(char c)
		{
			return TilesList.FirstOrDefault(t => t.Symbol == c);
		}
	}
}