using Labyrinth.Scripts.GameLevels;
using Labyrinth.Scripts.GameLevels.LevelTiles;

namespace Labyrinth.Scripts.Rendering;

public static class LevelRendering
{
	public static void RenderLevel(Level level)
	{
		GameConsole.Clear();

		var tiles = level.Tiles;
		foreach (var y in tiles)
		{
			foreach (var x in y)
			{
				TileRendering.RenderTile(x, false);
			}

			GameConsole.WriteLine();
		}
	}
}