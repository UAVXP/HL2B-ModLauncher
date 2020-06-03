using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ModLauncher
{
	public partial class ModManager : Form
	{
#if DEBUG
		public static string gamePath = @"D:\Games\HL2Leak\MegaBuild";
#else
		public static string gamePath = Directory.GetCurrentDirectory();
#endif
		public ModManager()
		{
			InitializeComponent();
		}

		private void ModManager_Load(object sender, EventArgs e)
		{
			RefreshModList();
		}

		public static bool isModDirectory(string path)
		{
			string[] ignoredirs =
			{
				"3dsmax2.5",
				"3dsmax3",
				"bin",
				"logos",
				"media",
				"pak",
				"Photoshop 5.5",
				"platform",
				"src_main",
				"XSI",
			};
			string shortDir = path.Substring(path.LastIndexOf('\\') + 1); // TODO: Path.Something
			foreach (string dir in ignoredirs)
			{
				if (dir == shortDir)
					//	if( shortDir.Contains(dir) )
					return false;
			}

			//	if (!File.Exists(path + "\\scripts\\liblist.gam"))
			//	{
			//		return false;
			//	}

			string[] possibleDirs =
			{
				"bin",
				"cfg",
				"maps",
				"mapsrc",
				"materials",
				"materialsrc",
				"models",
				"modelsrc",
				"resource",
				"SAVE",
				"scenes",
				"screenshots",
				"scripts",
				"sound",
				"testscripts",
			};

			int count = 0;
			foreach (string dir in possibleDirs)
			{
				if (Directory.Exists(path + "\\" + dir))
				{
					count++;
				}
			}

			return (count > 0);
		}

		private string TranslateModDirectory(string dir)
		{
			dir = dir.ToLower();
			switch (dir)
			{
				case "cstrike":
					dir = "Counter-Strike";
					break;
				case "hl2":
					dir = "Half-Life 2";
					break;
				case "tf2":
				case "tfc":
					dir = "TeamFortress 2";
					break;
				case "hl1":
					dir = "Half-Life Source";
					break;
				default:
					break;
			}

			return dir;
		}

		private void RefreshModList()
		{
			pnlModList.Controls.Clear();

			string[] gamefolders = Directory.GetDirectories(gamePath);
			foreach (string dir in gamefolders)
			{
				if (!isModDirectory(dir))
					continue;

				string ddir = dir.Substring(dir.LastIndexOf('\\') + 1);
				LibList liblist = new LibList(gamePath, ddir);

				ModManagerItem item = new ModManagerItem();

				string gamename = liblist.GetGameName();

				if (gamename == "")
				{
					gamename = TranslateModDirectory(ddir);
				}

				item.ModName = gamename;
				item.ImageURL = "https://hl2-beta.ru/media/downloads/usercontent/Airex_inside.jpg";
				pnlModList.Controls.Add(item);

			}
			Console.WriteLine("Total of {0} elements in list", pnlModList.Controls.Count);
		}
	}
}
