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
		public static string gamePath = @"D:\Games\HL2Leak\AHL2_Rewrite";
#else
		public static string gamePath = Directory.GetCurrentDirectory();
#endif

		bool bFullyLoaded = false;
		Settings settings = new Settings(gamePath);
		SettingsInternal sinternal = new SettingsInternal();
		ConsoleForm con;

		public MainForm()
		{
			InitializeComponent();

			sinternal = settings.GetSettings();
		}

		private void ConsoleLog(string text)
		{
			if (con != null && !con.IsDisposed && con.Visible)
				con.Log(text);
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

		public void RefreshModList()
		{
			string maxLengthGameName = "";
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

			Console.WriteLine("Refreshing mods");
			foreach (Mod_v2 mod in sinternal.Mods)
			{
				Console.WriteLine(string.Format("\t{0}, {1}, {2}, {3}", mod.Dir, mod.Name, mod.Parameters, mod.ServerParameters));
			}

			// TODO: Need to redo whole process: firstly do a loop on saved mods?
		/**/
			foreach (string dir in gamefolders)
			{
				Console.WriteLine("Checking " + dir + "...");
				if (isModDirectory(dir))
				{
					string ddir = dir.Substring(dir.LastIndexOf('\\') + 1);


					// Here was an old mod name translating and stuff


					//	Console.WriteLine("Game: " + gamename);

						//Mod_v2 mod = new Mod_v2
						//{
						//    Dir = ddir,
						//    Name = ((gamename != "") ? gamename : ddir)
						//};

						//List<Mod_v2> test = sinternal.Mods; // settings.GetMods()
						//foreach (Mod_v2 storedMod in test)
						//{
						////	Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", storedMod.Dir, storedMod.Name, storedMod.Parameters, storedMod.ServerParameters));
						//    if (storedMod.Dir == ddir) // Restoring parameters for mod
						//    {
						//        mod.Parameters = storedMod.Parameters;
						//        mod.ServerParameters = storedMod.ServerParameters;
						//    }
						//}

						//mods.Add(mod);

					// Searching in stored mods
					List<Mod_v2> results = sinternal.Mods.FindAll(x => x.Dir == ddir);
					if (results.Count <= 0)
					{
						Mod_v2 mod = new Mod_v2();
						mod.Dir = ddir;
					//	mod.Name = ((gamename != "") ? gamename : ddir); // NOTE: We're not using this anymore, but maybe later I'll implement an internal mod renaming
						mod.Name = mod.Dir;
						mod.Parameters = "";
						mod.ServerParameters = "";

						sinternal.Mods.Add(mod);
					}
				}
			}
		//	foreach (Mod_v2 mod in mods)
			foreach (Mod_v2 mod in sinternal.Mods)
			{
			//	if (!isModDirectory(mod.Dir))
			//		continue;

			//	modList.Items.Add(mod.Name);

				LibList liblist = new LibList(gamePath, mod.Dir);
				string gamename = liblist.GetGameName();

				if (gamename == "") // There's still no information about this mod at liblist.gam
				{
					gamename = TranslateModDirectory(mod.Dir); // Trying to translate mod directory with known names
				}

				string fullgamename = (gamename != "") ? gamename : mod.Dir;
				modList.Items.Add(fullgamename);

				if (fullgamename.Length > maxLengthGameName.Length)
					maxLengthGameName = fullgamename;
			}

			// Choosing saved mod
			string choosedGameMod = getModDirectory();
			int k = 0;
			bool isModFound = false;
		//	foreach (Mod_v2 val in mods)
			foreach (Mod_v2 val in sinternal.Mods)
		//	foreach (Mod_v2 val in modList.Items) // TODO: Later
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
			//	foreach (Mod_v2 val in mods)
				foreach (Mod_v2 val in sinternal.Mods) // TODO: Later
			//	foreach (Mod_v2 val in modList.Items)
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
			/**/

			/* VXP: TODO: Later. New listing?
				modList.Items.AddRange(sinternal.Mods.ToArray());
				int iMods = 0;
				foreach (Mod_v2 mod in modList.Items)
				{
					modList.Items[iMods] = mod.Dir;
					iMods++;
				}

				SelectLatestStoredMod();
			*/

			// Resize the dropdown
			Graphics g = Graphics.FromHwnd( this.Handle );
			SizeF stringsize = g.MeasureString( maxLengthGameName, modList.Font );

			int endWidth = 0;
			endWidth += modList.Margin.Left;
			endWidth += (int)stringsize.Width;
			endWidth += 13; // Width of a dropdown arrow button on Win7/.NET Framework 4.8 (boo-hoo, magic constant)
			endWidth += modList.Margin.Right;

			
			modList.Size = new Size( endWidth, modList.Size.Height );
			modList.DropDownWidth = endWidth;
		}

		private void SelectLatestStoredMod()
		{
			foreach (Mod_v2 mod in sinternal.Mods)
			{

			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RefreshModList();
			bFullyLoaded = true;

			lblGamePath.Text = "Game: " + gamePath;

			con = new ConsoleForm();
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
			foreach (Mod_v2 mod in sinternal.Mods)
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

			if (modList.SelectedIndex >= 0)
			{
				gameParametersText.Text = sinternal.Mods[modList.SelectedIndex].Parameters;
				srvParametersText.Text = sinternal.Mods[modList.SelectedIndex].ServerParameters;
			}

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

				startInfo.UseShellExecute = false;
				startInfo.RedirectStandardOutput = true;
				startInfo.RedirectStandardError = true;

			//	process.EnableRaisingEvents = true;
				process.OutputDataReceived += (sender, args) => ConsoleLog(args.Data);
				process.ErrorDataReceived += (sender, args) => ConsoleLog(args.Data);
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

				if (!isHLDS)
				{
					process.BeginOutputReadLine();
					process.BeginErrorReadLine();

				//	process.StandardOutput.BaseStream.Flush();

					// https://stackoverflow.com/questions/22080431/redirectstandardoutput-doesnt-fire-until-console-process-finishes
				}
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
				try
				{
					return	Path.GetDirectoryName(proc.Modules[0].FileName).Equals(gamePath) ||
							Path.GetDirectoryName(proc.Modules[0].FileName).Equals(String.Format("{0}\\bin", gamePath));
				}
				catch { return false; }
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
				startProcess("hl2.exe");
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

		private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			if (con == null || con.IsDisposed)
				con = new ConsoleForm();

			if (!con.Visible)
				con.Show();
			else
				con.Focus();
		}
	}
}
