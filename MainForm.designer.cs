namespace ModLauncher
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.srvStartButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gameStartButton = new System.Windows.Forms.Button();
			this.ttAdditionalParams = new System.Windows.Forms.ToolTip(this.components);
			this.ttChooseModification = new System.Windows.Forms.ToolTip(this.components);
			this.ttCommon = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblGamePath = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRefreshMods = new System.Windows.Forms.ToolStripMenuItem();
			this.modList = new System.Windows.Forms.ToolStripComboBox();
			this.gameParametersText = new System.Windows.Forms.TextBox();
			this.srvParametersText = new System.Windows.Forms.TextBox();
			this.tmrRunningCheck = new System.Windows.Forms.Timer(this.components);
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetWindowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// srvStartButton
			// 
			this.srvStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.srvStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.srvStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.srvStartButton.Location = new System.Drawing.Point(21, 19);
			this.srvStartButton.Name = "srvStartButton";
			this.srvStartButton.Size = new System.Drawing.Size(196, 32);
			this.srvStartButton.TabIndex = 23;
			this.srvStartButton.Text = "Start";
			this.srvStartButton.UseVisualStyleBackColor = false;
			this.srvStartButton.Click += new System.EventHandler(this.srvStartButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.srvParametersText);
			this.groupBox1.Controls.Add(this.srvStartButton);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.groupBox1.Location = new System.Drawing.Point(263, 34);
			this.groupBox1.MinimumSize = new System.Drawing.Size(239, 93);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(239, 93);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dedicated server (hlds.exe)";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.gameParametersText);
			this.groupBox2.Controls.Add(this.gameStartButton);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.groupBox2.Location = new System.Drawing.Point(11, 34);
			this.groupBox2.MinimumSize = new System.Drawing.Size(239, 93);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 93);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game (hl2.exe)";
			// 
			// gameStartButton
			// 
			this.gameStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gameStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.gameStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gameStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.gameStartButton.Location = new System.Drawing.Point(21, 19);
			this.gameStartButton.Name = "gameStartButton";
			this.gameStartButton.Size = new System.Drawing.Size(196, 32);
			this.gameStartButton.TabIndex = 23;
			this.gameStartButton.Text = "Start";
			this.gameStartButton.UseVisualStyleBackColor = false;
			this.gameStartButton.Click += new System.EventHandler(this.gameStartButton_Click);
			// 
			// ttAdditionalParams
			// 
			this.ttAdditionalParams.ToolTipTitle = "Additional Parameters";
			// 
			// ttChooseModification
			// 
			this.ttChooseModification.ToolTipTitle = "Modification";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGamePath});
			this.statusStrip1.Location = new System.Drawing.Point(0, 139);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(514, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 26;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblGamePath
			// 
			this.lblGamePath.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblGamePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.lblGamePath.Name = "lblGamePath";
			this.lblGamePath.Size = new System.Drawing.Size(117, 17);
			this.lblGamePath.Text = "toolStripStatusLabel1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.btnRefreshMods,
            this.modList,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(514, 27);
			this.menuStrip1.TabIndex = 27;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// btnRefreshMods
			// 
			this.btnRefreshMods.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnRefreshMods.Image = global::ModLauncher.Properties.Resources.refresh;
			this.btnRefreshMods.Name = "btnRefreshMods";
			this.btnRefreshMods.Size = new System.Drawing.Size(28, 23);
			this.btnRefreshMods.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// modList
			// 
			this.modList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.modList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modList.Name = "modList";
			this.modList.Size = new System.Drawing.Size(121, 23);
			this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
			// 
			// gameParametersText
			// 
			this.gameParametersText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gameParametersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.gameParametersText.ForeColor = System.Drawing.Color.Silver;
			this.gameParametersText.Location = new System.Drawing.Point(21, 57);
			this.gameParametersText.Name = "gameParametersText";
			this.gameParametersText.Size = new System.Drawing.Size(196, 20);
			this.gameParametersText.TabIndex = 29;
			this.gameParametersText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameParametersText_KeyDown);
			// 
			// srvParametersText
			// 
			this.srvParametersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.srvParametersText.ForeColor = System.Drawing.Color.Silver;
			this.srvParametersText.Location = new System.Drawing.Point(21, 57);
			this.srvParametersText.Name = "srvParametersText";
			this.srvParametersText.Size = new System.Drawing.Size(196, 20);
			this.srvParametersText.TabIndex = 30;
			this.srvParametersText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srvParametersText_KeyDown);
			// 
			// tmrRunningCheck
			// 
			this.tmrRunningCheck.Enabled = true;
			this.tmrRunningCheck.Interval = 500;
			this.tmrRunningCheck.Tick += new System.EventHandler(this.tmrRunningCheck_Tick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetWindowSizeToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// resetWindowSizeToolStripMenuItem
			// 
			this.resetWindowSizeToolStripMenuItem.Name = "resetWindowSizeToolStripMenuItem";
			this.resetWindowSizeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.resetWindowSizeToolStripMenuItem.Text = "Reset Window Size";
			this.resetWindowSizeToolStripMenuItem.Click += new System.EventHandler(this.resetWindowSizeToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ModLauncher.Properties.Resources.background002;
			this.ClientSize = new System.Drawing.Size(514, 161);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.Coral;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(10000, 200);
			this.MinimumSize = new System.Drawing.Size(278, 200);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LeakNet - Mod Launcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button srvStartButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button gameStartButton;
		private System.Windows.Forms.ToolTip ttAdditionalParams;
		private System.Windows.Forms.ToolTip ttChooseModification;
		private System.Windows.Forms.ToolTip ttCommon;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblGamePath;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		public System.Windows.Forms.ToolStripComboBox modList;
		private System.Windows.Forms.ToolStripMenuItem btnRefreshMods;
		private System.Windows.Forms.TextBox gameParametersText;
		private System.Windows.Forms.TextBox srvParametersText;
		private System.Windows.Forms.Timer tmrRunningCheck;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetWindowSizeToolStripMenuItem;
	}
}