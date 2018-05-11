using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Diagnostics;

using System.IO;
using Microsoft.Win32;

namespace ModLauncher
{
	public partial class MainForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HTCAPTION = 0x2;
		[DllImport("User32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("User32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Define the CS_DROPSHADOW constant
		private const int CS_DROPSHADOW = 0x00020000;
		// Override the CreateParams property
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

#if DEBUG
		public static string gamePath = @"D:\Games\HL2Leak\AHL2_R";
#else
		public static string gamePath = Directory.GetCurrentDirectory();
#endif

		public List<Mod> mods = new List<Mod>();
		bool bFullyLoaded = false;
		Settings settings = new Settings(gamePath);
		frmParameters gameparams;

		public MainForm()
		{
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e)
		{
			SaveAdditionalParameters();
			this.Close();
		}

		private void minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void move_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
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
			string shortDir = path.Substring(path.LastIndexOf('\\') + 1);
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
			foreach(string dir in possibleDirs)
			{
				if (Directory.Exists(path + "\\" + dir))
				{
					count++;
				}
			}

			return (count > 0);
		}
		public static string getRegistryMainPath()
		{
			return "Software\\LeakNet";
		}
		public static bool isRegistryPathValid(string str)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(str);
		//	Console.WriteLine("Checking registry path " + str);
		//	if (key == null) return false;
			if (key == null)
			{
			//	Console.WriteLine("Creating a new registry path "+str);
				RegistryKey key2 = Registry.CurrentUser.CreateSubKey(str);
				key2.Close();
			}
			key = Registry.CurrentUser.OpenSubKey(str);
		//	Console.WriteLine("Key Count is " + key.ValueCount);
			if (key.ValueCount > 0)
			{
				key.Close();
				return true;
			}
			return false;
		}
		public static string getRegistryValue(string main, string subkey)
		{
			try
			{
				if (!isRegistryPathValid(getRegistryMainPath()))
					return "";

				RegistryKey key = Registry.CurrentUser.OpenSubKey(main);
				string result = (string)key.GetValue(subkey);
			//	if (String.Compare(result, "") == 0)
			//		key.SetValue(subkey, "");
				key.Close();
				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Can't get registry value!");
				return "";
			}
		}
		public static bool setRegistryValue(string subkey, string value)
		{
		//	Console.WriteLine("Registry path/value is: " +
		//						getRegistryMainPath() + "\\" +
		//						subkey + "\\" +
		//						value);
			try
			{

				RegistryKey key = Registry.CurrentUser.CreateSubKey(getRegistryMainPath());
				key.SetValue(subkey, value);
				key.Close();
				Console.WriteLine("Writing " + value + " at " + subkey);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
			return true;
		}

		public static string getModDirectory()
		{
		//	return getRegistryValue(FileSystem.Main.getRegistryMainPath(), "LNGameMod");
			string regValue = getRegistryValue(getRegistryMainPath(), "LNGameMod");
			if (!isModDirectory(gamePath + "\\" + regValue))
				return "";

			return regValue;
		}

		private string TranslateModDirectory(string dir)
		{
			dir = dir.ToLower();
			switch (dir)
			{
			case "cstrike":
				dir = "Counter-Strike Source";
				break;
			case "hl2":
				dir = "Half-Life 2";
				break;
			case "tf2":
			case "tfc":
				dir = "Team Fortress 2";
				break;
			case "hl1":
				dir = "Half-Life Source";
				break;
			default:
				break;
			}

			return dir;
		}

		public void RefreshModList()
		{
			modList.Items.Clear();
			mods.Clear();

			if (!Directory.Exists(gamePath))
			{
				MessageBox.Show("This folder doesn't exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string[] gamefolders = Directory.GetDirectories(gamePath);
			if (gamefolders.Length <= 0)
			{
				MessageBox.Show("This folder doesn't have any detectable mod folders", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			foreach (string dir in gamefolders)
			{
				if (isModDirectory(dir))
				{
					string ddir = dir.Substring(dir.LastIndexOf('\\') + 1);

					LibList liblist = new LibList(gamePath, ddir);
					string gamename = liblist.GetGameName();

					if (gamename == "") // There's still no information about this mod at liblist.gam
					{
						gamename = TranslateModDirectory(ddir); // Trying to translate mod directory with known names
					}

				//	Console.WriteLine("Game: " + gamename);

					Mod mod = new Mod
					{
						Dir = ddir,
						Name = ((gamename != "") ? gamename : ddir)
					};

					List<Mod> test = settings.GetMods();
					foreach (Mod storedMod in test)
					{
						if (storedMod.Dir == ddir) // Restoring parameters for mod
						{
							mod.Parameters = storedMod.Parameters;
							mod.ServerParameters = storedMod.ServerParameters;
						}
					}

				//	Console.WriteLine(string.Format("{0}, {1}, {2}", mod.Dir, mod.Name, mod.Parameters));
					mods.Add(mod);
				}
			}
			foreach (Mod mod in mods)
			{
				modList.Items.Add(mod.Name);
			}

			// Choosing saved mod
			string choosedGameMod = getModDirectory();
			int k = 0;
			bool isModFound = false;
			foreach (Mod val in mods)
			{
				if (val.Dir == choosedGameMod)
				{
					modList.SelectedIndex = k;
					isModFound = true;
					break;
				}
				k++;
			}
			if (!isModFound)
			{
				k = 0;
				foreach (Mod val in mods)
				{
					if (val.Dir.IndexOf(choosedGameMod) >= 0)
					{
						modList.SelectedIndex = k;
						break;
					}
					k++;
				}
			}
		}

		public void RefreshMapLists()
		{
			gameMapList.Items.Clear();
			srvMapList.Items.Clear();

			Mod mod = mods[modList.SelectedIndex];
			string choosedMod = mod.Dir;

			if (!Directory.Exists(gamePath + "\\" + choosedMod + "\\maps"))
				return;

			int i = 0;
			foreach (string map in Directory.GetFiles(gamePath + "\\" + choosedMod + "\\maps", "*.bsp", SearchOption.TopDirectoryOnly))
			{
				string mapnoext = Path.GetFileNameWithoutExtension(map);
				gameMapList.Items.Add(mapnoext);
				srvMapList.Items.Add(mapnoext);

				// Very stupid way to find this
				if (gameparams.gameParametersText.Text.Contains("+map " + mapnoext))
				{
					gameMapList.SelectedIndex = i;
				}
				if (gameparams.srvParametersText.Text.Contains("+map " + mapnoext))
				{
					srvMapList.SelectedIndex = i;
				}

				i++;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			gameparams = new frmParameters(this);

			RefreshModList();
			bFullyLoaded = true;

			lblGamePath.Text = "Game: " + gamePath;
		}

		public void SaveAdditionalParameters()
		{
		//	setRegistryValue("GameParameters", gameParametersText.Text);
		//	setRegistryValue("ServerParameters", srvParametersText.Text);

		//	mods[modList.SelectedIndex].Parameters = gameParametersText.Text;
		//	mods[modList.SelectedIndex].ServerParameters = srvParametersText.Text;

			// Write to file
			bool successfulSave = settings.WriteSettings(mods);
			if (!successfulSave)
				MessageBox.Show("Mod parameters cannot be saved!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

		//	gameParametersText.Text = mods[modList.SelectedIndex].Parameters;
		//	srvParametersText.Text = mods[modList.SelectedIndex].ServerParameters;
		}

	//	private bool isExtended = false;
		private void MainForm_Shown(object sender, EventArgs e)
		{
		//	this.Height = 140;

		//	gameParametersText.Text = getRegistryValue(getRegistryMainPath(), "GameParameters");
		//	srvParametersText.Text = getRegistryValue(getRegistryMainPath(), "ServerParameters");

			if (mods.Count <= 0) return; //prevents System.ArgumentOutOfRangeException if no mods exist

			gameparams.gameParametersText.Text = mods[modList.SelectedIndex].Parameters;
			gameparams.srvParametersText.Text = mods[modList.SelectedIndex].ServerParameters;

			RefreshMapLists();

		}

		/*
		private void additionalParamsBut_Click(object sender, EventArgs e)
		{
			isExtended = !isExtended;

			Button button = (sender as Button);
			if (isExtended)
			{
				this.Height = 182;
				button.Image = Properties.Resources.arrowUp;

				// VXP: Do we need this anymore?
				if (gameParametersText.CanFocus)
				{
					gameParametersText.Focus();
					gameParametersText.Select(gameParametersText.TextLength, 1);
				}
			}
			else
			{
				this.Height = 140;
				button.Image = Properties.Resources.arrowDown;
			}
		}
		*/

		private void startProcess(string name)
		{
			if (mods.Count <= 0) return; //prevents System.ArgumentOutOfRangeException if no mods exist and user press run

		//	string choosedMod = modList.SelectedItem.ToString();
			string choosedMod = mods[modList.SelectedIndex].Dir;
			Console.WriteLine("Trying to run " + choosedMod);

		//	Environment.SetEnvironmentVariable("VPROJECT", gamePath + "\\" + getModDirectory());
			Environment.SetEnvironmentVariable("VPROJECT", gamePath + "\\" + choosedMod);
		//	string oldCurDir = Directory.GetCurrentDirectory();
		//	Directory.SetCurrentDirectory(pathToApp);
		//	Process.Start(pathToApp + "\\" + appExecutable, "-game " + FileSystem.Main.getModDirectory());
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();

			bool isHLDS = name.Contains("hlds.exe");

			if (isHLDS)
			{
				Console.WriteLine("Running HLDS...");
				startInfo.WorkingDirectory = String.Format(@"{0}\bin", gamePath);
				startInfo.FileName = String.Format(@"{0}\bin\{1}", gamePath, name);
				startInfo.Arguments = String.Format("-game \"{0}\" {1}", choosedMod, gameparams.srvParametersText.Text);
			}
			else
			{
				Console.WriteLine("Running HL2...");
				startInfo.WorkingDirectory = gamePath;
				startInfo.FileName = String.Format(@"{0}\{1}", gamePath, name);
				startInfo.Arguments = String.Format("-game \"{0}\" {1}", choosedMod, gameparams.gameParametersText.Text);
			}

			startInfo.CreateNoWindow = true;
		//	MessageBox.Show(pathToApp + "; " + (pathToApp + "\\" + appExecutable) + "; " + ("-game " + FileSystem.Main.getModDirectory()));
		//	Process.Start(startInfo);
			process.StartInfo = startInfo;
			process.Start();
		//	Directory.SetCurrentDirectory(oldCurDir);

			// Cleaning up
			startInfo = null;
			process.Dispose();
			process = null;
			GC.Collect();
		}

		private void closeProcess(string name)
		{
			Process[] processes = Process.GetProcessesByName(name);
			Console.WriteLine("Trying to kill " + name);
			int procCount = processes.Length;
			if (procCount > 0)
			{
				try
				{
					for (int i = 0; i < procCount; i++)
					{
						//	Console.WriteLine("\t" + Path.GetDirectoryName(processes[i].Modules[0].FileName));
						// Close only process that exists aside program
						bool isHLDS = name.Contains("hlds");
						bool bSamePath = Path.GetDirectoryName(processes[i].Modules[0].FileName).Equals(isHLDS ? gamePath + "\\bin" : gamePath);
						if (bSamePath)
						{
							processes[i].Kill();
							processes[i].Close();
							processes[i].Dispose();
						}
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			// Cleaning up
			processes = null;
			GC.Collect();
		}

		private void gameStartButton_Click(object sender, EventArgs e)
		{
			startProcess( "hl2.exe" );
		}

		private void gameParametersText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				startProcess("hl2.exe");
			}
		}

		private void gameStopButton_Click(object sender, EventArgs e)
		{
			closeProcess( "hl2" );
		}

		private void srvStartButton_Click(object sender, EventArgs e)
		{
			startProcess( "hlds.exe" );
		}

		private void srvParametersText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				startProcess("hlds.exe");
			}
		}

		private void srvStopButton_Click(object sender, EventArgs e)
		{
			closeProcess( "hlds" );
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefreshModList();
		}

		private void modList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!bFullyLoaded)
				return;

		//	string choosedMod = (sender as ComboBox).SelectedItem.ToString();
			string choosedMod = mods[modList.SelectedIndex].Dir;
			setRegistryValue("LNGameMod", choosedMod);

			// Saving parameters into registry
		//	SaveAdditionalParameters();

			gameparams.gameParametersText.Text = mods[modList.SelectedIndex].Parameters;
			gameparams.srvParametersText.Text = mods[modList.SelectedIndex].ServerParameters;

			RefreshMapLists();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		//	gameparams.ShowDialog();
			if (gameparams == null)
				gameparams = new frmParameters(this);

			if (!gameparams.Visible)
				gameparams.Show();
			else
				gameparams.Focus();
		}
	}
}
