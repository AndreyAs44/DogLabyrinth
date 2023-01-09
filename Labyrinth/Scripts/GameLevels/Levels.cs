using System.Collections.Generic;
using System.IO;
using Labyrinth.Scripts.GameConsole;

namespace Labyrinth.Scripts.GameLevels
{
	public class Levels
	{
		private const string LevelsPath = "Resources/Levels/";

		public Levels()
		{
			LoadLevels();
		}

		public List<Level> LevelsList { get; private set; }

		private void LoadLevels()
		{
			Console.WriteLine(Directory.GetCurrentDirectory());
			// load file from LevelsPath

		}
	}
}