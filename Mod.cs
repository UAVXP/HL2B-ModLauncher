using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace ModLauncher
{
	[Serializable]
	public class Mod // Need to stay as "Mod" for backwards-compatibility deserialization. The old version
	{
		public string Dir { get; set; }
		public string Name { get; set; }
		public string Parameters { get; set; }
		public string ServerParameters { get; set; }

	/*
		public static explicit operator Mod(Mod_v2 obj)
	//	public static implicit operator Mod(Mod_v2 obj)
		{
			Mod output = new Mod() { Dir = obj.Dir, Name = obj.Name, Parameters = obj.Parameters, ServerParameters = obj.ServerParameters };
			return output;
		}
	*/
	}

	[Serializable]
	public class Mod_v2 // New version
	{
		public string Dir { get; set; }
		public string Name { get; set; } // Not used anymore
		public string Parameters { get; set; }
		public string ServerParameters { get; set; }

	/*
		public static explicit operator Mod_v2(Mod obj)
	//	public static implicit operator Mod_v2(Mod obj)
		{
			Mod_v2 output = new Mod_v2() { Dir = obj.Dir, Name = obj.Name, Parameters = obj.Parameters, ServerParameters = obj.ServerParameters };
			return output;
		}
	*/

		public Mod_v2()
		{
			this.Dir = "";
			this.Name = "";
			this.Parameters = "";
			this.ServerParameters = "";
		}

		public Mod_v2(Mod obj)
		{
			Console.WriteLine("Conversion method");
			this.Dir = obj.Dir;
			this.Name = obj.Name;
			this.Parameters = obj.Parameters;
			this.ServerParameters = obj.ServerParameters;
		}
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
		public List<Mod_v2> Mods { get; set; }
		public string GameMod { get; set; }
		public WindowSize WindowSize { get; set; }

		public SettingsInternal()
		{
			this.Version = Settings.INTERNAL_VERSION;
			this.Mods = new List<Mod_v2>();
			this.GameMod = "";
			this.WindowSize = new WindowSize(530, 200);
		}
	}
}
