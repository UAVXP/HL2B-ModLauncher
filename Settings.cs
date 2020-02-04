using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Windows.Forms;

namespace ModLauncher
{
	class Settings
	{
		public static int INTERNAL_VERSION = 2;

		private string GamePath;
		public Settings(string gamePath)
		{
			this.GamePath = gamePath;
			// Writing
			/*
			List<Mod_v2> mods = new List<Mod_v2>();
			mods.Add(new Mod_v2 { Dir = "testmod", Parameters = "+map crg" });
			mods.Add(new Mod_v2 { Dir = "hl2", Parameters = "+map d1_trainstation_01" });

			FileStream fstream = new FileStream("ModLauncher.dat", FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(fstream, mods);
			fstream.Close();


			// Reading
			fstream = new FileStream("ModLauncher.dat", FileMode.Open);
			bf = new BinaryFormatter();
			List<Mod_v2> modsR = (List<Mod_v2>)bf.Deserialize(fstream);
			fstream.Close();

			foreach (Mod_v2 mod in modsR)
			{
				Console.WriteLine(string.Format("{0}, {1}, {2}", mod.Dir, mod.Name, mod.Parameters));
			}
			*/

		/*
			SettingsInternal sinternal1 = new SettingsInternal();
			sinternal1.GameMod = "testmod";
			sinternal1.WindowSize = new WindowSize(9000, 9000);
			List<Mod_v2> mods1 = new List<Mod_v2>();
			mods1.Add(new Mod_v2 { Dir = "testmod", Name = "TestMod!!!", Parameters = "+map crg", ServerParameters = "" });
			mods1.Add(new Mod_v2 { Dir = "hl2", Name = "I'm HL2!", Parameters = "+map d1_trainstation_01", ServerParameters = "" });
			sinternal1.Mods = mods1;
			FileStream fstream1 = new FileStream("ModLauncher.dat", FileMode.Create);
			BinaryFormatter bf1 = new BinaryFormatter();
			bf1.Serialize(fstream1, sinternal1);
			fstream1.Close();

			FileStream fstream2 = new FileStream("ModLauncher.dat", FileMode.Open);
			BinaryFormatter bf2 = new BinaryFormatter();
			SettingsInternal sinternal2 = (SettingsInternal)bf2.Deserialize(fstream2);
			fstream2.Close();
			Console.WriteLine(String.Format("Test restoring - GM: {0}, {1}x{2}", sinternal2.GameMod, sinternal2.WindowSize.Width, sinternal2.WindowSize.Height));
			foreach (Mod_v2 mod in sinternal2.Mods)
			{
				Console.WriteLine(string.Format("\t{0}, {1}, {2}, {3}", mod.Dir, mod.Name, mod.Parameters, mod.ServerParameters));
			}
		*/
		}

		private bool TryConvert(FileStream fstream, SettingsInternal sint)
		{
			Console.WriteLine("Converting the old settings...");

			fstream.Position = 0; // Clearing out

			BinaryFormatter bf = new BinaryFormatter();
			List<Mod> temp = (List<Mod>)bf.Deserialize(fstream);
		//	sinternalR.Mods = (List<Mod_v2>)temp;
			sint.Mods = new List<Mod_v2>();

			foreach (Mod modv1 in temp)
			{
				Mod_v2 tempmod = new Mod_v2();
				tempmod.Dir = modv1.Dir;
				tempmod.Name = modv1.Name;
				tempmod.Parameters = modv1.Parameters;
				tempmod.ServerParameters = modv1.ServerParameters;
			}

		//	List<Mod_v2> temp = (List<Mod_v2>)bf.Deserialize(fstream);
		//	sinternalR.Mods = temp;
			sint.GameMod = "";
			sint.Version = INTERNAL_VERSION;
			sint.WindowSize = new WindowSize(530, 200);

			return true;
		}

		private bool TryConvert(object deserialized, ref SettingsInternal sint)
		{
			Console.WriteLine("Converting the old settings...");

			sint = new SettingsInternal(); // Clearing out

			List<Mod> temp = (List<Mod>)deserialized;
		//	List<Mod_v2> temp = (new List<Mod>()).ConvertAll<Mod_v2>(a => new Mod_v2());
		//	sinternalR.Mods = (List<Mod_v2>)temp;
			sint.Mods = new List<Mod_v2>();
			sint.GameMod = "";
			sint.Version = INTERNAL_VERSION;
			sint.WindowSize = new WindowSize(530, 200);

		/*
			foreach (Mod modv1 in temp)
			{
				Mod_v2 tempmod = new Mod_v2();
				tempmod.Dir = modv1.Dir;
				tempmod.Name = modv1.Name;
				tempmod.Parameters = modv1.Parameters;
				tempmod.ServerParameters = modv1.ServerParameters;
			}
		*/
			sint.Mods = temp.ConvertAll<Mod_v2>(a => new Mod_v2(a));
			if (sint.Mods.Count <= 0)
				return false;

		//	List<Mod_v2> temp = (List<Mod_v2>)bf.Deserialize(fstream);
		//	sinternalR.Mods = temp;

			return true;
		}

		public SettingsInternal GetSettings()
		{
			FileStream fstream = null;
			try
			{
				bool isNotExist = !File.Exists(this.GamePath + "\\ModLauncher.dat");
				FileAttributes fattrib = FileAttributes.Normal;
				if (!isNotExist)
					fattrib = File.GetAttributes(this.GamePath + "\\ModLauncher.dat");

				if (((fattrib & FileAttributes.ReadOnly) != FileAttributes.ReadOnly) || isNotExist)
					fstream = new FileStream(this.GamePath + "\\ModLauncher.dat", FileMode.OpenOrCreate);
				else
					fstream = new FileStream(this.GamePath + "\\ModLauncher.dat", FileMode.Open, FileAccess.Read); // Just try to open it
			}
			catch (UnauthorizedAccessException ex) // If the file is actually not accessible or somehow stays read-only
			{
				return new SettingsInternal();
			}

			if (fstream == null || fstream.Length <= 0)
			{
			//	fstream.Close();
				return new SettingsInternal();
			}

			BinaryFormatter bf = new BinaryFormatter();
		//	bf.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
			object notSerialized = bf.Deserialize(fstream);
			SettingsInternal sinternalR = new SettingsInternal();
			try
			{
				sinternalR = (SettingsInternal)notSerialized;
			}
			catch (InvalidCastException ex)
			{
				// Maybe convertable?
			//	TryConvert(fstream, sinternalR);
				if (!TryConvert(notSerialized, ref sinternalR))
				{
					MessageBox.Show("Conversion from the older ModLauncher.dat format was probably invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			fstream.Close();

			Console.WriteLine(String.Format("Test restoring222 - GM: {0}, {1}x{2}", sinternalR.GameMod, sinternalR.WindowSize.Width, sinternalR.WindowSize.Height));
			Console.WriteLine("sinternalR.Mods.Count is " + sinternalR.Mods.Count);
			foreach (Mod_v2 mod in sinternalR.Mods)
			{
				Console.WriteLine(string.Format("\t{0}, {1}, {2}, {3}", mod.Dir, mod.Name, mod.Parameters, mod.ServerParameters));
			}

			// Restoring older version of settings
			if (sinternalR.Version < INTERNAL_VERSION)
			{
				// Future conversion. Older .dat format conversion is probably just ended in checks above (TryConvert)
			}

			return sinternalR;
		}

		public bool WriteSettings( SettingsInternal sinternal )
		{
		//	if (mods.Count <= 0)
		//		return false;

			try
			{
			//	FileStream fstream = new FileStream("ModLauncher.dat", FileMode.OpenOrCreate);
				FileStream fstream = new FileStream(this.GamePath + "\\ModLauncher.dat", FileMode.Create);
				if (fstream == null)
				{
					fstream.Close();
					return false;
				}

				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fstream, sinternal);

				fstream.Close();

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}
