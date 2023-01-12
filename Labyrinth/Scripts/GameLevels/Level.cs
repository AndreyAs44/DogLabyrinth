using System.Collections.Generic;
using Labyrinth.Scripts.GameLevels.LevelTiles;
using Labyrinth.Scripts.GameLogic;

namespace Labyrinth.Scripts.GameLevels;

public class Level
{
	public int LevelNumber { get; }
	public int Width { get; }
	public int Height { get; }
	public List<List<Tile>> Tiles { get; }
	public Coordinate WinPosition { get; }
	
	public Level(in List<List<Tile>> tiles)
	{
		LevelNumber = Levels.LevelsList.Count + 1;
		Height = tiles.Count;
		Width = tiles[0].Count;
		Tiles = new List<List<Tile>>(tiles);
		
		// Find the win position
		for (int x = 0; x < Height; x++)
		{
			for (int y = 0; y < Width; y++)
			{
				if (Tiles[x][y].Symbol == LevelTiles.Tiles.WinTile.Symbol)
				{
					WinPosition = new Coordinate(x, y);
					return;
				}
			}
		}
	}
	
	public Tile GetTile(in Coordinate coordinate)
	{
		return Tiles[coordinate.x][coordinate.y];
	}

	public override string ToString()
	{
		var s = string.Empty;
		s += $"Level: {LevelNumber} Width: {Width} Height:{Height}.\n";
		foreach (var row in Tiles)
		{
			var rowString = string.Empty;
			foreach (var tile in row) rowString += tile.Symbol;
			s += $"{rowString}\n";
		}

		return s.TrimEnd('\n');
	}
}