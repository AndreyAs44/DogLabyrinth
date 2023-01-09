using System;

namespace Labyrinth.Scripts.GameConsole;

public static class GameConsole
{
	public static void WriteLine(string message)
	{
		Console.WriteLine(message);
	}

	public static void Write(string message)
	{
		Console.Write(message);
	}

	public static void Clear()
	{
		Console.Clear();
	}

	public static void ReplaceSymbol(int x, int y, char symbol)
	{
		Console.SetCursorPosition(x, y);
		Console.Write(symbol);
	}

	public static void ReplaceLine(int line, string message)
	{
		Console.SetCursorPosition(0, line);
		Console.Write(message);
	}

	public static ConsoleKeyInfo ReadKey()
	{
		return Console.ReadKey();
	}

	public static string ReadLine()
	{
		return Console.ReadLine();
	}
}