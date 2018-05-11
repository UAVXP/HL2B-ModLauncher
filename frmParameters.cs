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

		MainForm parent;
		public frmParameters(MainForm parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private void close_Click(object sender, EventArgs e)
		{
		//	this.Close();
			this.Hide();
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
