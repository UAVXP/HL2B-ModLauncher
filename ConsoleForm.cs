using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace ModLauncher
{
	public partial class ConsoleForm : Form
	{
		delegate void SetTextCallback(string text);

		public ConsoleForm()
		{
			InitializeComponent();
		}

		public void Log(string text)
		{
			if (this.textBox1.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(Log);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.textBox1.AppendText(String.Format("{0}\r\n", text));
				int savedSelectionStart = this.textBox1.SelectionStart;
				int savedSelectionLength = this.textBox1.SelectionLength;
				this.textBox1.Select(this.textBox1.TextLength, 1);
				this.textBox1.ScrollToCaret();
				this.textBox1.Select(savedSelectionStart, savedSelectionLength);
			}
		}

		private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This will only display a standard application output/errors (stdout/stderr) for HL2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
