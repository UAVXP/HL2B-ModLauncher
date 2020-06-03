using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModLauncher
{
	public partial class ModManagerItem : UserControl
	{
		public ModManagerItem()
		{
			InitializeComponent();
		}

		private string modname;
		public string ModName
		{
			get { return modname;}
			set
			{
				modname = value;
				lblModName.Text = modname;
			}
		}

		private string imageUrl; // 
		public string ImageURL
		{
			get { return imageUrl; }
			set
			{
				imageUrl = value;
				pbImage.ImageLocation = imageUrl;
			}
		}
	}
}
