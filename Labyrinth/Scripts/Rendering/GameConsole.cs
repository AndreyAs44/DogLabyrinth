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
	}

	public static void ReplaceSymbol(char symbol, int x, int y, ConsoleColor color = ConsoleColor.White)
	{
		Console.SetCursorPosition(x, y);
		Console.Write(symbol);
	}
	
	public static void ReplaceSymbol(char symbol, Coordinate coordinate, ConsoleColor color = ConsoleColor.White)
	{
		Console.SetCursorPosition(coordinate.x, coordinate.y);
		Console.Write(symbol.ToString());
	}

	public static void ReplaceLine(string message, int line, ConsoleColor color = ConsoleColor.White)
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