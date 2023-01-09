using System;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth.Scripts.GameLevels.LevelTiles
{
	public static class Tiles
	{
		// Tile types
		public static readonly Tile EmptyTile = new(' ', true, ConsoleColor.Black);
		public static readonly Tile PlayerTile = new('@', true, ConsoleColor.Yellow);
		public static readonly Tile GoalTile = new('X', true, ConsoleColor.Green);
		public static readonly Tile WallTile = new('#', false, ConsoleColor.DarkGray);

		// List of all tiles
		public static List<Tile> AllTiles => new()
		{
			EmptyTile, 
			PlayerTile, 
			GoalTile, 
			WallTile
		};

		public static Tile GetTile(char c)
		{
			var tile = AllTiles.FirstOrDefault(t => t.Symbol == c);
			return tile;
		}
	}
}