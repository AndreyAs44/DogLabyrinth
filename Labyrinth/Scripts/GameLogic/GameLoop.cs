using System;
using System.Threading;
using Labyrinth.Scripts.GameLevels;
using Labyrinth.Scripts.Rendering;

namespace Labyrinth.Scripts.GameLogic;

public static class GameLoop
{
	public static void StartGameLoop()
	{
		Levels.LoadLevels();
		var levelsCount = Levels.LevelsList.Count;
		for (int i = 0; i < levelsCount; i++)
		{
			var level = Levels.LevelsList[i];
			Game.Play(level);

			// не прошли ли мы все уровни?
			if (i == levelsCount - 1)
			{
				ExitFromGame();
				return;
			}

			// спросить игрока, хочет ли он продолжеить
			GameConsole.Clear();
			GameConsole.Write("Do you want to continue? (");
			GameConsole.Write("y", ConsoleColor.Green);
			GameConsole.Write("/");
			GameConsole.Write("n", ConsoleColor.Red);
			GameConsole.WriteLine(")");
			
			// получить ответ от игрока
			while (true)
			{
				var answer = GameConsole.ReadKey();
				if (answer.Key == ConsoleKey.Y)
				{
					break;
				}
				if (answer.Key == ConsoleKey.N)
				{
					ExitFromGame();
					return;
				}
				
				GameConsole.ReplaceLine("", 1);
			}
		}
	}

	private static void ExitFromGame()
	{
		GameConsole.Clear();
		GameConsole.WriteLine("Thanks for playing!", ConsoleColor.Green);
		GameConsole.WriteLine("@PArrotCode 2023", ConsoleColor.DarkGray);
		Thread.Sleep(1000);
		Environment.Exit(0);
	}
}