using System.Collections.Generic;
using Labyrinth.Scripts.GameLevels.LevelTiles;

namespace Labyrinth.Scripts.GameLevels
{
	public class Level
	{
		public Level(in List<List<Tile>> tiles)
		{
			LevelNumber = Levels.LevelsList.Count + 1;
			Height = tiles.Count;
			Width = tiles[0].Count;
			Tiles = new List<List<Tile>>(tiles);
		}
		
		public int LevelNumber { get; }
		public int Width { get; }
		public int Height { get; }
		public List<List<Tile>> Tiles { get; }

		public override string ToString()
		{
			var s = string.Empty;
			s += $"Level: {LevelNumber} Width: {Width} Height:{Height}.\n";
			foreach (var row in Tiles)
			{
				var rowString = string.Empty;
				foreach (var tile in row)
				{
					rowString += tile.Symbol;
				}
				s += $"{rowString}\n";
			}

			return s.TrimEnd('\n');
		}
	}
}