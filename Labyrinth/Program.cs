using System;
using Labyrinth.Scripts.GameLogic;

namespace Labyrinth
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.CursorVisible = false;
			GameLoop.StartGameLoop();

			/*
			for (int i = 0; i < levels.Length; i++)
			{
				var level = levels[i];
				var coordinates = new Coordinates(1, 1);
				var finish = FindFinish(level);
				while (IsFinish(coordinates, finish) == false)
				{
					Console.Clear();
					DrawLevel(level, coordinates);
					ConsoleKeyInfo key = Console.ReadKey();
				}

				Console.Clear();
				Console.WriteLine("You win!");
				
				if (levels.Length - 1 == i)
				{
					Console.WriteLine("Game over!");
					Console.WriteLine("Press any key to exit...");
					Console.ReadKey();
					return;
				}*/
		}
	}
}