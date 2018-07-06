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
#if DEBUG
		public static string gamePath = @"D:\Games\HL2Leak\AHL2_R";
#else
		public static string gamePath = Directory.GetCurrentDirectory();
#endif

		bool bFullyLoaded = false;
		Settings settings = new Settings(gamePath);
		SettingsInternal sinternal = new SettingsInternal();

		public MainForm()
		{
			InitializeComponent();

			sinternal = settings.GetSettings();
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

		public string getModDirectory()
		{
		//	return getRegistryValue(FileSystem.Main.getRegistryMainPath(), "LNGameMod");
		//	string regValue = getRegistryValue(getRegistryMainPath(), "LNGameMod");
			string regValue = sinternal.GameMod;
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

				/*
					Mod mod = new Mod
					{
						Dir = ddir,
						Name = ((gamename != "") ? gamename : ddir)
					};

				//	List<Mod> test = settings.GetMods();
					List<Mod> test = sinternal.Mods;
					foreach (Mod storedMod in test)
					{
					//	Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", storedMod.Dir, storedMod.Name, storedMod.Parameters, storedMod.ServerParameters));
						if (storedMod.Dir == ddir) // Restoring parameters for mod
						{
							mod.Parameters = storedMod.Parameters;
							mod.ServerParameters = storedMod.ServerParameters;
						}
					}

				//	Console.WriteLine(string.Format("{0}, {1}, {2}", mod.Dir, mod.Name, mod.Parameters));
					mods.Add(mod);
				*/
				}
			}
		//	foreach (Mod mod in mods)
			foreach (Mod mod in sinternal.Mods)
			{
				modList.Items.Add(mod.Name);
			}

			// Choosing saved mod
			string choosedGameMod = getModDirectory();
			int k = 0;
			bool isModFound = false;
		//	foreach (Mod val in mods)
			foreach (Mod val in sinternal.Mods)
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
			//	foreach (Mod val in mods)
				foreach (Mod val in sinternal.Mods)
				{
					if (val.Dir.IndexOf(choosedGameMod) >= 0)
					{
						modList.SelectedIndex = k;
						break;
					}
					k++;
				}
			}

		//	sinternal.Mods = mods; // ???
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RefreshModList();
			bFullyLoaded = true;

			lblGamePath.Text = "Game: " + gamePath;
		}

		public void SaveAdditionalParameters() // TODO: Rename
		{
			Console.WriteLine("Carefully closing an application...");
		//	setRegistryValue("GameParameters", gameParametersText.Text);
		//	setRegistryValue("ServerParameters", srvParametersText.Text);

		//	mods[modList.SelectedIndex].Parameters = gameParametersText.Text;
		//	mods[modList.SelectedIndex].ServerParameters = srvParametersText.Text;

			SaveWindowSize(this.Width, this.Height);

			// Write to file
		//	bool successfulSave = settings.WriteSettings(mods);
		//	SettingsInternal sint = new SettingsInternal();
		//	sint.GameMod = sinternal.GameMod;
		//	sint.WindowSize = sinternal.WindowSize;
		//	sint.Mods = mods;
		//	bool successfulSave = settings.WriteSettings(sint);

		//	sinternal.Mods = mods;

			Console.WriteLine(String.Format("Test saving - GM: {0}, {1}x{2}", sinternal.GameMod, sinternal.WindowSize.Width, sinternal.WindowSize.Height));
			foreach (Mod mod in sinternal.Mods)
			{
				Console.WriteLine(string.Format("\t{0}, {1}, {2}, {3}", mod.Dir, mod.Name, mod.Parameters, mod.ServerParameters));
			}

			bool successfulSave = settings.WriteSettings(sinternal);
			if (!successfulSave)
				MessageBox.Show("Mod parameters cannot be saved!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

		//	gameParametersText.Text = mods[modList.SelectedIndex].Parameters;
		//	srvParametersText.Text = mods[modList.SelectedIndex].ServerParameters;
		}

		private void SaveWindowSize(int width = 530, int height = 200) // Change after resizing in editor
		{
		//	setRegistryValue("LNMainWindowWidth", width.ToString());
		//	setRegistryValue("LNMainWindowHeight", height.ToString());

			sinternal.WindowSize = new WindowSize(width, height);
		}
		private void RestoreWindowSize()
		{
			int width = this.Width;
		//	int.TryParse(getRegistryValue(getRegistryMainPath(), "LNMainWindowWidth"), out width);
			width = sinternal.WindowSize.Width;
			if (width != 0 && width != this.Width)
				this.Width = width;

			int height = this.Height;
		//	int.TryParse(getRegistryValue(getRegistryMainPath(), "LNMainWindowHeight"), out height);
			width = sinternal.WindowSize.Height;
			if (height != 0 && height != this.Height)
				this.Height = height;
		}
		private void CenterizeWindow()
		{
			// Centering the window
			Rectangle rect = Screen.PrimaryScreen.WorkingArea;
			this.Top = (rect.Height / 2) - (this.Height / 2);
			this.Left = (rect.Width / 2) - (this.Width / 2);
		}

	//	private bool isExtended = false;
		private void MainForm_Shown(object sender, EventArgs e)
		{
		//	this.Height = 140;

			RestoreWindowSize();
			CenterizeWindow();

		//	gameParametersText.Text = getRegistryValue(getRegistryMainPath(), "GameParameters");
		//	srvParametersText.Text = getRegistryValue(getRegistryMainPath(), "ServerParameters");

			if (sinternal.Mods.Count <= 0) return; //prevents System.ArgumentOutOfRangeException if no mods exist

			gameParametersText.Text = sinternal.Mods[modList.SelectedIndex].Parameters;
			srvParametersText.Text = sinternal.Mods[modList.SelectedIndex].ServerParameters;

		//	sinternal.Mods = mods; // FIXME: Storing a right link, but better make mods to sinternal.Mods
		}

		private void resetWindowSizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveWindowSize(); // Saving the default parameters
			RestoreWindowSize();
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
			if (sinternal.Mods.Count <= 0) return; //prevents System.ArgumentOutOfRangeException if no mods exist and user press run

		//	string choosedMod = modList.SelectedItem.ToString();
			string choosedMod = sinternal.Mods[modList.SelectedIndex].Dir;
			Console.WriteLine("Trying to run " + choosedMod);

		//	Environment.SetEnvironmentVariable("VPROJECT", gamePath + "\\" + getModDirectory());
			Environment.SetEnvironmentVariable("VPROJECT", gamePath + "\\" + choosedMod);
		//	string oldCurDir = Directory.GetCurrentDirectory();
		//	Directory.SetCurrentDirectory(pathToApp);
		//	Process.Start(pathToApp + "\\" + appExecutable, "-game " + FileSystem.Main.getModDirectory());
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();

			bool isHLDS = name.Contains("hlds.exe");

			if (!isHLDS)
			{
				Console.WriteLine("Running HL2...");
				startInfo.WorkingDirectory = gamePath;
				startInfo.FileName = String.Format(@"{0}\{1}", gamePath, name);
				startInfo.Arguments = String.Format("-game \"{0}\" {1}",
					choosedMod,
					sinternal.Mods[modList.SelectedIndex].Parameters);
			}
			else
			{
				Console.WriteLine("Running HLDS...");
				startInfo.WorkingDirectory = String.Format(@"{0}\bin", gamePath);
				startInfo.FileName = String.Format(@"{0}\bin\{1}", gamePath, name);
				startInfo.Arguments = String.Format("-game \"{0}\" {1}",
					choosedMod,
					sinternal.Mods[modList.SelectedIndex].ServerParameters);
			}

			startInfo.CreateNoWindow = true;
		//	MessageBox.Show(pathToApp + "; " + (pathToApp + "\\" + appExecutable) + "; " + ("-game " + FileSystem.Main.getModDirectory()));
		//	Process.Start(startInfo);
			process.StartInfo = startInfo;

			try
			{
				Console.WriteLine("\tParameters: " + startInfo.Arguments);
				process.Start();

			}
			catch { MessageBox.Show("Game process cannot run properly. Check executable (hl2.exe or bin\\hlds.exe) for existance", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

		private bool isRunning(string name)
		{
			Process[] processes = Process.GetProcessesByName(name);
			foreach (Process proc in processes)
			{
				bool bSamePath = false;
				try
				{
					bSamePath = Path.GetDirectoryName(proc.Modules[0].FileName).Equals(gamePath);
				}
				catch { return false; }
				return bSamePath;
			}

			return false;
		}

		private void tmrRunningCheck_Tick(object sender, EventArgs e)
		{
			if (isRunning("hl2"))
				gameStartButton.Text = "Stop";
			else
				gameStartButton.Text = "Start";

			if (isRunning("hlds"))
				srvStartButton.Text = "Stop";
			else
				srvStartButton.Text = "Start";
		}

		private void gameStartButton_Click(object sender, EventArgs e)
		{
		//	startProcess( "hl2.exe" );
			if (isRunning("hl2"))
			{
				closeProcess("hl2");
			}
			else
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
		//	startProcess( "hlds.exe" );
			if (isRunning("hlds"))
			{
				closeProcess("hlds");
			}
			else
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
			string choosedMod = sinternal.Mods[modList.SelectedIndex].Dir;
		//	setRegistryValue("LNGameMod", choosedMod);
			sinternal.GameMod = choosedMod;

			// Saving parameters into registry
		//	SaveAdditionalParameters();

			gameParametersText.Text = sinternal.Mods[modList.SelectedIndex].Parameters;
			srvParametersText.Text = sinternal.Mods[modList.SelectedIndex].ServerParameters;
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
		//	SaveAdditionalParameters();
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveAdditionalParameters();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			RefreshModList();
		}

		private void gameParametersText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				startProcess("hlds.exe");
			}
		}

		private void srvParametersText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				startProcess("hlds.exe");
			}
		}

		private void gameParametersText_TextChanged(object sender, EventArgs e)
		{
			sinternal.Mods[modList.SelectedIndex].Parameters = gameParametersText.Text;
		}

		private void srvParametersText_TextChanged(object sender, EventArgs e)
		{
			sinternal.Mods[modList.SelectedIndex].ServerParameters = srvParametersText.Text;
		}

		private void gameParametersText_Leave(object sender, EventArgs e)
		{
			SaveAdditionalParameters();
		}

		private void srvParametersText_Leave(object sender, EventArgs e)
		{
			SaveAdditionalParameters();
		}
	}
}
