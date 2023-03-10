using System;
using Labyrinth.Scripts.GameLogic;

namespace Labyrinth.Scripts.Rendering;

public static class GameConsole
{
	public static void WriteLine(string message = "", ConsoleColor color = ConsoleColor.White)
	{
		Console.ForegroundColor = color;
		Console.WriteLine(message);
		Console.ResetColor();
	}

	public static void Write(string message = "", ConsoleColor color = ConsoleColor.White)
	{
		Console.ForegroundColor = color;
		Console.Write(message);
		Console.ResetColor();
	}

	public static void Clear()
	{
		Console.Clear();
		WriteLine();
	}

	public static void ReplaceSymbol(char symbol, int x, int y, ConsoleColor color = ConsoleColor.White)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(symbol);
		Console.ResetColor();
	}

	public static void ReplaceSymbol(char symbol, Coordinate coordinate, ConsoleColor color = ConsoleColor.White)
	{
		Console.SetCursorPosition(coordinate.x, coordinate.y);
		Console.ForegroundColor = color;
		Console.Write(symbol.ToString());
		Console.ResetColor();
	}

	public static void ReplaceLine(string message, int line, ConsoleColor color = ConsoleColor.White)
	{
		Console.SetCursorPosition(0, line);
		Console.ForegroundColor = color;
		Console.Write(message);
		Console.ResetColor();
	}

	public static ConsoleKeyInfo ReadKey()
	{
		Console.SetCursorPosition(0, 0);
		var key = Console.ReadKey();
		Console.SetCursorPosition(0, 0);
		Console.Write(" ");
		return key;
	}
}