using System;

namespace Labyrinth.Scripts.GameConsole
{
	public static class Console
	{
		public static void WriteLine(string message)
		{
			System.Console.WriteLine(message);
		}

		public static void Write(string message)
		{
			System.Console.Write(message);
		}

		public static void Clear()
		{
			System.Console.Clear();
		}

		public static void ReplaceSymbol(int x, int y, char symbol)
		{
			System.Console.SetCursorPosition(x, y);
			System.Console.Write(symbol);
		}

		public static void ReplaceLine(int line, string message)
		{
			System.Console.SetCursorPosition(0, line);
			System.Console.Write(message);
		}

		public static ConsoleKeyInfo ReadKey()
		{
			return System.Console.ReadKey();
		}

		public static string ReadLine()
		{
			return System.Console.ReadLine();
		}
	}
}