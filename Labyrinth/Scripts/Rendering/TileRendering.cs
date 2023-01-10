using Labyrinth.Scripts.GameLevels.LevelTiles;
using Labyrinth.Scripts.GameLogic;

namespace Labyrinth.Scripts.Rendering;

public static class TileRendering
{
	public static void RenderTile(Tile tile, bool isWriteLine)
	{
		if (isWriteLine)
		{
			GameConsole.WriteLine(tile.Symbol.ToString(), tile.ConsoleColor);
		}
		else
		{
			GameConsole.Write(tile.Symbol.ToString(), tile.ConsoleColor);
		}
	}
	
	public static void ReplaceTile(Tile tile, Coordinate coordinate)
	{
		GameConsole.ReplaceSymbol(tile.Symbol, coordinate, tile.ConsoleColor);
	}
}