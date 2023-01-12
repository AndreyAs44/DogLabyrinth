using System;
using Labyrinth.Scripts.GameLevels;
using Labyrinth.Scripts.GameLevels.LevelTiles;
using Labyrinth.Scripts.Rendering;

namespace Labyrinth.Scripts.GameLogic;

public static class Game
{
	private static Level _level;
	private static Coordinate _playerPosition;
	private static int _infoLineOffset = 1;
	
	public static void Play(Level level)
	{
		// инициализация уровня
		_level = level;
		
		// консоль:
		GameConsole.Clear();
		GameConsole.WriteLine($"Level: {_level.LevelNumber}.");
		LevelRendering.RenderLevel(level);

		// отрисовываем изначальную позицию игрока
		_playerPosition = new Coordinate(1, 1 + _infoLineOffset);
		TileRendering.ReplaceTile(Tiles.PlayerTile, _playerPosition);

		// запускаем игру
		while (IsWinPosition() == false)
		{
			MovePlayer();
		}
	}

	private static void MovePlayer()
	{
		var direction = GameConsole.ReadKey().Key;
		Coordinate newPosition;
		switch (direction)
		{
			case ConsoleKey.A:
			case ConsoleKey.LeftArrow:
				newPosition = _playerPosition + Coordinate.left;
				if (IsMovable(newPosition)) SetNewPlayerPosition(_playerPosition, newPosition);
				break;
			case ConsoleKey.D:
			case ConsoleKey.RightArrow:
				newPosition = _playerPosition + Coordinate.right;
				if (IsMovable(newPosition)) SetNewPlayerPosition(_playerPosition, newPosition);
				break;
			case ConsoleKey.W:
			case ConsoleKey.UpArrow:
				newPosition = _playerPosition + Coordinate.up;
				if (IsMovable(newPosition)) SetNewPlayerPosition(_playerPosition, newPosition);
				break;
			case ConsoleKey.S:
			case ConsoleKey.DownArrow:
				newPosition = _playerPosition + Coordinate.down;
				if (IsMovable(newPosition)) SetNewPlayerPosition(_playerPosition, newPosition);
				break;
		}
	}

	private static bool IsMovable(Coordinate position)
	{
		if (position.x > 0 && position.x < _level.Width && position.y > 0 && position.y < _level.Height)
		{
			return false;
		}

		return _level.GetTile(position).IsWalkable;
	}
	
	private static void SetNewPlayerPosition(Coordinate oldPosition, Coordinate newPosition)
	{
		TileRendering.ReplaceTile(_level.GetTile(oldPosition), oldPosition);
		_playerPosition = newPosition;
		TileRendering.ReplaceTile(Tiles.PlayerTile, _playerPosition);
	}

	private static bool IsWinPosition()
	{
		return _playerPosition == _level.WinPosition;
	}

}