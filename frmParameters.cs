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
	public partial class frmParameters : Form
	{
		MainForm parent;
		public frmParameters(MainForm parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private void frmParameters_Shown(object sender, EventArgs e)
		{
			if (parent.mods.Count <= 0) return; //prevents System.ArgumentOutOfRangeException if no mods exist and user press params

			gameParametersText.Text = parent.mods[parent.modList.SelectedIndex].Parameters;
			srvParametersText.Text = parent.mods[parent.modList.SelectedIndex].ServerParameters;
		}

		private void gameParametersText_Leave(object sender, EventArgs e)
		{
			parent.SaveAdditionalParameters();
		}

		private void srvParametersText_Leave(object sender, EventArgs e)
		{
			parent.SaveAdditionalParameters();
		}

		private void gameParametersText_TextChanged(object sender, EventArgs e)
		{
			parent.mods[parent.modList.SelectedIndex].Parameters = gameParametersText.Text;
		}

		private void srvParametersText_TextChanged(object sender, EventArgs e)
		{
			parent.mods[parent.modList.SelectedIndex].ServerParameters = srvParametersText.Text;
		}
	}
}
