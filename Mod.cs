using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace ModLauncher
{
	[Serializable]
	public class Mod
	{
		public string Dir { get; set; }
		public string Name { get; set; }
		public string Parameters { get; set; }
		public string ServerParameters { get; set; }
	}

	[Serializable]
	public class WindowSize
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public WindowSize(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}
	}

	[Serializable]
	public class SettingsInternal
	{
		public int Version { get; set; }
		public List<Mod> Mods { get; set; }
		public string GameMod { get; set; }
		public WindowSize WindowSize { get; set; }

		public SettingsInternal()
		{
			this.Version = 2;
			this.Mods = new List<Mod>();
			this.GameMod = "";
			this.WindowSize = new WindowSize(530, 200);
		}
	}
}
