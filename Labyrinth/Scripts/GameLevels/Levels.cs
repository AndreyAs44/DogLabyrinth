using System;
using System.Collections.Generic;
using System.IO;
using Labyrinth.Scripts.GameLevels.LevelTiles;

namespace Labyrinth.Scripts.GameLevels;

public static class Levels
{
	private const string LevelsPath = "Resources/Levels/";

	private static List<Level> _levelsList = new();
	public static List<Level> LevelsList => _levelsList;

	public static void LoadLevels()
	{
		var directoryPath = Path.Combine(Environment.CurrentDirectory, LevelsPath);
		var levels = Directory.GetFiles(directoryPath);
		foreach (var t in levels)
		{
			var filePath = Path.Combine(LevelsPath, t);
			var text = File.ReadAllLines(filePath);

			var tiles = ParseLevel(text);
			var level = new Level(tiles);
			_levelsList.Add(level);
		}
	}

	private static List<List<Tile>> ParseLevel(in string[] text)
	{
		var tiles = new List<List<Tile>>();
		foreach (var line in text)
		{
			var tileLine = new List<Tile>();
			foreach (var t in line)
			{
				var tile = Tiles.GetTile(t);
				tileLine.Add(tile);
			}
			tiles.Add(tileLine);
		}

		return tiles;
	}
}