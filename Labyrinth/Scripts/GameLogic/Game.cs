using Labyrinth.Scripts.GameLevels;
using Labyrinth.Scripts.GameLevels.LevelTiles;
using Labyrinth.Scripts.Rendering;

namespace Labyrinth.Scripts.GameLogic;

public static class Game
{
	public static void Play(Level level)
	{
		// отрисовываем изначальный уровень
		LevelRendering.RenderLevel(level);
		
		// отрисовываем изначальную позицию игрока
		var player = Tiles.PlayerTile;
		var playerPosition = new Coordinate(1, 1);
		TileRendering.ReplaceTile(player, playerPosition);

		GameConsole.ReadKey();
	}
}