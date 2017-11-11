using System;
using System.Collections.Generic;
using System.Text;

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
}
