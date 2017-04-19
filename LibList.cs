using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace ModLauncher
{
	class LibList
	{
		private string Filename { get; set; }

		public LibList(string gamePath, string modDirectory)
		{
			this.Filename = gamePath + "\\" + modDirectory + "\\scripts\\liblist.gam";
			Console.WriteLine(this.Filename);
		}

		private bool GetValue(string line, string forSearch, out string value)
		{
			value = "";

			try
			{
				line = line.Trim();
				int forSearchLength = forSearch.Length;
				int findMaterial = line.IndexOf(forSearch);
				if (findMaterial < 0) // If there's no forSearch in line
					return false;
				if (findMaterial > 0) // If forSearch is further than 0 symbol, i.e.: "name" "game" - it's just value, not parameter name
					return false;

				value = line.Substring(forSearchLength + 1).Replace('/', '\\').Trim(trimChars: '"');

				return true;
			}
			catch { }

			return false;
		}

		public string GetGameName()
		{
			string[] file = new string[] { };
			try
			{
				file = File.ReadAllLines(this.Filename);
			}
			catch { }

			foreach (string line in file)
			{
				string value = "";

				bool foundGameName = GetValue(line, "game", out value);
				if (foundGameName)
					return value;
			}
			return "";
		}
	}
}
