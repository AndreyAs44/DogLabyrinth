using Labyrinth.Scripts.GameLevels;

namespace Labyrinth.Scripts.Rendering;

public static class LevelRendering
{
	public static void RenderLevel(Level level)
	{
		var tiles = level.Tiles;
		foreach (var x in tiles)
		{
			foreach (var y in x)
			{
				TileRendering.RenderTile(y, false);
			}

			GameConsole.WriteLine();
		}
	}
}