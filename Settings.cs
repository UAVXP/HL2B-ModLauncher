using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
		}

		public List<Mod> GetMods()
		{
			try
			{
				FileStream fstream = new FileStream(this.GamePath + "\\ModLauncher.dat", FileMode.OpenOrCreate);
				if (fstream == null || fstream.Length <= 0)
				{
					fstream.Close();
					return new List<Mod>();
				}

				BinaryFormatter bf = new BinaryFormatter();
				List<Mod> modsR = (List<Mod>)bf.Deserialize(fstream);

				fstream.Close();

				return modsR;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new List<Mod>();
			}
		}

		public bool WriteSettings( List<Mod> mods )
		{
			if (mods.Count <= 0)
				return false;

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
				bf.Serialize(fstream, mods);

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
