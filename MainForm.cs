//#define TRANSLATION 1

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

		public MainForm()
		{
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e)
		{
			SaveAdditionalParameters();

		//	logout();
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
			string[] ignoredirs = {
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
			//	if (dir == shortDir)
				if( shortDir.Contains(dir) )
					return false;
			}

		//	if (!File.Exists(path + "\\scripts\\liblist.gam"))
		//	{
		//		return false;
		//	}

			string[] possibleDirs = {
								 "cfg",
								 "maps",
								 "materials",
								 "models",
								 "resource",
								 "SAVE",
								 "scenes",
								 "scripts",
								 "sound",
							 };

			int count = 0;
			foreach(string dir in possibleDirs)
			{
				if (Directory.Exists(path + "\\" + dir))
				{
					count++;
				}
			}
			if (count <= 0)
				return false;

			return true;
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
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
			return true;
		}

	//	public static string gamePath = Directory.GetCurrentDirectory();
		
#if DEBUG
		public static string gamePath = @"D:\AHL2_R";
#else
		public static string gamePath = Directory.GetCurrentDirectory();
#endif

		public static string getModDirectory()
		{
		//	return getRegistryValue(FileSystem.Main.getRegistryMainPath(), "LNGameMod");
			string regValue = getRegistryValue(getRegistryMainPath(), "LNGameMod");
			if (!isModDirectory(gamePath + "\\" + regValue))
				return "";

			return regValue;
		}

		private static void removeProc(Process[] proc, int count)
		{
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					proc[i].Kill();
				}
			}
		}

#if TRANSLATION
		private void TranslateModDirectory(ref string dir)
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
		}
#endif

		private void MainForm_Load(object sender, EventArgs e)
		{
			modList.Items.Clear();
			List<string> listOfMods = new List<string>();
		//	foreach (string dir in Directory.GetDirectories(Directory.GetCurrentDirectory()))
			foreach (string dir in Directory.GetDirectories(gamePath))
			{
				if (isModDirectory(dir))
				{
					listOfMods.Add(dir.Substring(dir.LastIndexOf('\\') + 1));
				}
			}
			modList.Items.AddRange(listOfMods.ToArray());

			// Choosing saved mod
			string choosedGameMod = getModDirectory();
			int k = 0;
			bool isModFound = false;
			ComboBox.ObjectCollection listItems = modList.Items;
			foreach (string val in listItems)
			{
			//	Console.WriteLine(val + " - " + choosedGameMod);
				if (val == choosedGameMod)
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
				foreach (string val in listItems)
				{
					if (val.IndexOf(choosedGameMod) >= 0)
					{
						modList.SelectedIndex = k;
						break;
					}
					k++;
				}
			}

#if TRANSLATION
			// Translating
			for (int i = 0; i < modList.Items.Count; i++)
			{
				string oldValue = (string)modList.Items[i];
				TranslateModDirectory(ref oldValue);
				modList.Items[i] = oldValue;
			}
#endif
		}

		private void SaveAdditionalParameters()
		{
			setRegistryValue("GameParameters", gameParametersText.Text);
			setRegistryValue("ServerParameters", srvParametersText.Text);
		}

		private bool isExtended = false;
		private void MainForm_Shown(object sender, EventArgs e)
		{
			this.Height = 140;

			gameParametersText.Text = getRegistryValue(getRegistryMainPath(), "GameParameters");
			srvParametersText.Text = getRegistryValue(getRegistryMainPath(), "ServerParameters");
		}

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

		private void parametersText_Leave(object sender, EventArgs e)
		{
		//	Console.WriteLine("unfocused");
			SaveAdditionalParameters();
		}

		private void startProcess(string name)
		{
			string choosedMod = modList.SelectedItem.ToString();
			setRegistryValue("LNGameMod", choosedMod);

			// Saving parameters into registry
			SaveAdditionalParameters();

		//	Environment.SetEnvironmentVariable("VPROJECT", gamePath + "\\" + getModDirectory());
			Environment.SetEnvironmentVariable("VPROJECT", gamePath + "\\" + choosedMod);
		//	string oldCurDir = Directory.GetCurrentDirectory();
		//	Directory.SetCurrentDirectory(pathToApp);
		//	Process.Start(pathToApp + "\\" + appExecutable, "-game " + FileSystem.Main.getModDirectory());
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.WorkingDirectory = String.Format(@"{0}\{1}", gamePath, choosedMod);
			startInfo.FileName = String.Format(@"{0}\{1}", gamePath, name);
			startInfo.Arguments = String.Format("-game \"{0}\" {1}", choosedMod, ((name.Contains("hlds.exe")) ? srvParametersText.Text : gameParametersText.Text));
			startInfo.CreateNoWindow = true;
		//	MessageBox.Show(pathToApp + "; " + (pathToApp + "\\" + appExecutable) + "; " + ("-game " + FileSystem.Main.getModDirectory()));
		//	Process.Start(startInfo);
			process.StartInfo = startInfo;
			process.Start();
		//	Directory.SetCurrentDirectory(oldCurDir);
		}

		private void closeProcess(string name)
		{
			Process[] processes = Process.GetProcessesByName(name);
			int procCount = processes.Length;
			removeProc(processes, procCount);
		}

		private void gameStartButton_Click(object sender, EventArgs e)
		{
			startProcess( "hl2.exe" );
		}

		private void gameStopButton_Click(object sender, EventArgs e)
		{
			closeProcess( "hl2" );
		}

		private void srvStartButton_Click(object sender, EventArgs e)
		{
			startProcess( @"bin\hlds.exe" );
		}

		private void srvStopButton_Click(object sender, EventArgs e)
		{
			closeProcess( "hlds" );
		}
	}
}
