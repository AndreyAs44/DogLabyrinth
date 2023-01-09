using System.Collections.Generic;
using Labyrinth.Scripts.GameLevels.LevelTiles;

namespace Labyrinth.Scripts.GameLevels
{
	public class Level
	{
		public Level(List<List<Tile>> tiles)
		{
			Height = tiles.Count;
			Width = tiles[0].Count;
			Tiles = tiles;
		}
		public int Width { get; }
		public int Height { get; }
		public List<List<Tile>> Tiles { get; }
	}
}