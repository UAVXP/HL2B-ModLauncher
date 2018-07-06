using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace ModLauncher
{

	class Settings
	{
		private string GamePath;
		public Settings(string gamePath)
		{
			this.GamePath = gamePath;
			// Writing
			/*
			List<Mod> mods = new List<Mod>();
			mods.Add(new Mod { Dir = "testmod", Parameters = "+map crg" });
			mods.Add(new Mod { Dir = "hl2", Parameters = "+map d1_trainstation_01" });

			FileStream fstream = new FileStream("ModLauncher.dat", FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(fstream, mods);
			fstream.Close();


			// Reading
			fstream = new FileStream("ModLauncher.dat", FileMode.Open);
			bf = new BinaryFormatter();
			List<Mod> modsR = (List<Mod>)bf.Deserialize(fstream);
			fstream.Close();

			foreach (Mod mod in modsR)
			{
				Console.WriteLine(string.Format("{0}, {1}, {2}", mod.Dir, mod.Name, mod.Parameters));
			}
			*/

		/*
			SettingsInternal sinternal1 = new SettingsInternal();
			sinternal1.GameMod = "testmod";
			sinternal1.WindowSize = new WindowSize(9000, 9000);
			List<Mod> mods1 = new List<Mod>();
			mods1.Add(new Mod { Dir = "testmod", Name = "TestMod!!!", Parameters = "+map crg", ServerParameters = "" });
			mods1.Add(new Mod { Dir = "hl2", Name = "I'm HL2!", Parameters = "+map d1_trainstation_01", ServerParameters = "" });
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
			foreach (Mod mod in sinternal2.Mods)
			{
				Console.WriteLine(string.Format("\t{0}, {1}, {2}, {3}", mod.Dir, mod.Name, mod.Parameters, mod.ServerParameters));
			}
		*/
		}

		public SettingsInternal GetSettings()
		{
			try
			{
				FileStream fstream = new FileStream(this.GamePath + "\\ModLauncher.dat", FileMode.OpenOrCreate);
				if (fstream == null || fstream.Length <= 0)
				{
					fstream.Close();
					return new SettingsInternal();
				}

				BinaryFormatter bf = new BinaryFormatter();
				SettingsInternal sinternalR = (SettingsInternal)bf.Deserialize(fstream);

				fstream.Close();

			//	Console.WriteLine(String.Format("Test restoring222 - GM: {0}, {1}x{2}", sinternalR.GameMod, sinternalR.WindowSize.Width, sinternalR.WindowSize.Height));
			//	foreach (Mod mod in sinternalR.Mods)
			//	{
			//		Console.WriteLine(string.Format("\t{0}, {1}, {2}, {3}", mod.Dir, mod.Name, mod.Parameters, mod.ServerParameters));
			//	}

				return sinternalR;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new SettingsInternal();
			}
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
