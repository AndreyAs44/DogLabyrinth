using System;
using Labyrinth.Scripts.GameLevels;

namespace Labyrinth
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			var levels = new Levels();

			/*string[] level1 =
			{
				"########################",
				"#                      #",
				"#                      #",
				"#                      #",
				"#            X         #",
				"#                      #",
				"#                      #",
				"#                      #",
				"#                      #",
				"########################"
			};
			string[] level2 =
			{
				"########################",
				"#      #               #",
				"#      #   #           #",
				"#      #   #           #",
				"#      #X  ######      #",
				"#      #####           #",
				"#                      #",
				"#                      #",
				"#                      #",
				"########################"
			};
			string[][] levels = new string[2][];
			levels[0] = level1;
			levels[1] = level2;

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
					switch (key.Key)
					{
						case ConsoleKey.UpArrow:
							if (IsMovable(level, new Coordinates(coordinates.x - 1, coordinates.y)))
							{
								coordinates.x--;
							}
							break;
						case ConsoleKey.DownArrow:
							if (IsMovable(level, new Coordinates(coordinates.x + 1, coordinates.y)))
							{
								coordinates.x++;
							}
							break;
						case ConsoleKey.LeftArrow:
							if (IsMovable(level, new Coordinates(coordinates.x, coordinates.y - 1)))
							{
								coordinates.y--;
							}
							break;
						case ConsoleKey.RightArrow:
							if (IsMovable(level, new Coordinates(coordinates.x, coordinates.y + 1)))
							{
								coordinates.y++;
							}
							break;
					}
				}

				Console.Clear();
				Console.WriteLine("You win!");
				
				if (levels.Length - 1 == i)
				{
					Console.WriteLine("Game over!");
					Console.WriteLine("Press any key to exit...");
					Console.ReadKey();
					return;
				}
				
				Console.WriteLine("Continue? (y, n)");
				while (true)
				{
					var key = Console.ReadKey();
					if (key.Key == ConsoleKey.Y)
					{
						break;
					}
					if (key.Key == ConsoleKey.N)
					{
						return;
					}
				}
			}*/
		}

		private static Coordinates FindFinish(string[] level)
		{
			for (int i = 0; i < level.Length; i++)
			{
				for (int j = 0; j < level[i].Length; j++)
				{
					if (level[i][j] == 'X')
					{
						return new Coordinates(i, j);
					}
				}
			}

			return null;
		}

		private static bool IsFinish(Coordinates player, Coordinates finish)
		{
			return player.x == finish.x && player.y == finish.y;
		}

		private static void DrawLevel(string[] level, Coordinates player)
		{
			for (int i = 0; i < level.Length; i++)
			{
				for (int j = 0; j < level[i].Length; j++)
				{
					if (i == player.x && j == player.y)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write("@");
						Console.ResetColor();
					}
					else if (level[i][j] == 'X')
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write(level[i][j].ToString()); 
						Console.ResetColor();
					}
					else
					{
						Console.Write(level[i][j].ToString());
					}
				}
				Console.WriteLine();
			}
		}

		private static bool IsMovable(string[] level, Coordinates player)
		{
			return level[player.x][player.y] == ' ' || level[player.x][player.y] == 'X';
		}

		public class Coordinates
		{
			public int x;
			public int y;

			public Coordinates(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}
	}
}