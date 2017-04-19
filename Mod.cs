using System;
using System.Collections.Generic;
using System.Text;

namespace ModLauncher
{
	[Serializable]
	class Mod
	{
		public string Dir { get; set; }
		public string Name { get; set; }
		public string Parameters { get; set; }
		public string ServerParameters { get; set; }
	}
}
