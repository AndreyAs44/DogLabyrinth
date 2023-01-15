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
		}
	}
}