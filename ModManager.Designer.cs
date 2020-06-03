namespace ModLauncher
{
	partial class ModManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlModList = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// pnlModList
			// 
			this.pnlModList.AutoScroll = true;
			this.pnlModList.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlModList.Location = new System.Drawing.Point(0, 0);
			this.pnlModList.Name = "pnlModList";
			this.pnlModList.Size = new System.Drawing.Size(800, 354);
			this.pnlModList.TabIndex = 0;
			// 
			// ModManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlModList);
			this.Name = "ModManager";
			this.Text = "ModManager";
			this.Load += new System.EventHandler(this.ModManager_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel pnlModList;
	}
}