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
			this.srvMapList = new System.Windows.Forms.ComboBox();
			this.srvStopButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gameMapList = new System.Windows.Forms.ComboBox();
			this.gameStopButton = new System.Windows.Forms.Button();
			this.gameStartButton = new System.Windows.Forms.Button();
			this.btnParams = new System.Windows.Forms.Button();
			this.ttAdditionalParams = new System.Windows.Forms.ToolTip(this.components);
			this.ttChooseModification = new System.Windows.Forms.ToolTip(this.components);
			this.ttCommon = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblGamePath = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modList = new System.Windows.Forms.ToolStripComboBox();
			this.btnRefreshMods = new System.Windows.Forms.Button();
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
			this.srvStartButton.Size = new System.Drawing.Size(133, 32);
			this.srvStartButton.TabIndex = 23;
			this.srvStartButton.Text = "Start";
			this.srvStartButton.UseVisualStyleBackColor = false;
			this.srvStartButton.Click += new System.EventHandler(this.srvStartButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.srvMapList);
			this.groupBox1.Controls.Add(this.srvStopButton);
			this.groupBox1.Controls.Add(this.srvStartButton);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.groupBox1.Location = new System.Drawing.Point(263, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(239, 93);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dedicated server (hlds.exe)";
			// 
			// srvMapList
			// 
			this.srvMapList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.srvMapList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.srvMapList.ForeColor = System.Drawing.Color.Silver;
			this.srvMapList.FormattingEnabled = true;
			this.srvMapList.Location = new System.Drawing.Point(21, 59);
			this.srvMapList.Name = "srvMapList";
			this.srvMapList.Size = new System.Drawing.Size(196, 21);
			this.srvMapList.TabIndex = 28;
			this.ttChooseModification.SetToolTip(this.srvMapList, "Here you can choose modification that you want to run");
			// 
			// srvStopButton
			// 
			this.srvStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.srvStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.srvStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.srvStopButton.Location = new System.Drawing.Point(160, 19);
			this.srvStopButton.Name = "srvStopButton";
			this.srvStopButton.Size = new System.Drawing.Size(57, 32);
			this.srvStopButton.TabIndex = 24;
			this.srvStopButton.Text = "Stop";
			this.ttCommon.SetToolTip(this.srvStopButton, "Notice: This will stop ALL of hlds.exe occurences from game directory!");
			this.srvStopButton.UseVisualStyleBackColor = false;
			this.srvStopButton.Click += new System.EventHandler(this.srvStopButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.gameMapList);
			this.groupBox2.Controls.Add(this.gameStopButton);
			this.groupBox2.Controls.Add(this.gameStartButton);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.groupBox2.Location = new System.Drawing.Point(12, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 93);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game (hl2.exe)";
			// 
			// gameMapList
			// 
			this.gameMapList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.gameMapList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gameMapList.ForeColor = System.Drawing.Color.Silver;
			this.gameMapList.FormattingEnabled = true;
			this.gameMapList.Location = new System.Drawing.Point(21, 58);
			this.gameMapList.Name = "gameMapList";
			this.gameMapList.Size = new System.Drawing.Size(196, 21);
			this.gameMapList.TabIndex = 27;
			this.ttChooseModification.SetToolTip(this.gameMapList, "Here you can choose modification that you want to run");
			// 
			// gameStopButton
			// 
			this.gameStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.gameStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gameStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.gameStopButton.Location = new System.Drawing.Point(160, 19);
			this.gameStopButton.Name = "gameStopButton";
			this.gameStopButton.Size = new System.Drawing.Size(57, 32);
			this.gameStopButton.TabIndex = 24;
			this.gameStopButton.Text = "Stop";
			this.ttCommon.SetToolTip(this.gameStopButton, "Notice: This will stop ALL of hl2.exe occurences from game directory!");
			this.gameStopButton.UseVisualStyleBackColor = false;
			this.gameStopButton.Click += new System.EventHandler(this.gameStopButton_Click);
			// 
			// gameStartButton
			// 
			this.gameStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.gameStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gameStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.gameStartButton.Location = new System.Drawing.Point(21, 19);
			this.gameStartButton.Name = "gameStartButton";
			this.gameStartButton.Size = new System.Drawing.Size(133, 32);
			this.gameStartButton.TabIndex = 23;
			this.gameStartButton.Text = "Start";
			this.gameStartButton.UseVisualStyleBackColor = false;
			this.gameStartButton.Click += new System.EventHandler(this.gameStartButton_Click);
			// 
			// btnParams
			// 
			this.btnParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.btnParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.btnParams.Location = new System.Drawing.Point(507, 67);
			this.btnParams.Name = "btnParams";
			this.btnParams.Size = new System.Drawing.Size(135, 26);
			this.btnParams.TabIndex = 25;
			this.btnParams.Text = "Parameters";
			this.ttCommon.SetToolTip(this.btnParams, "Notice: This will stop ALL of hl2.exe occurences from game directory!");
			this.btnParams.UseVisualStyleBackColor = false;
			this.btnParams.Click += new System.EventHandler(this.button1_Click);
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 138);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(654, 22);
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
            this.modList});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(654, 27);
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
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// modList
			// 
			this.modList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.modList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modList.Name = "modList";
			this.modList.Size = new System.Drawing.Size(121, 23);
			this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
			// 
			// btnRefreshMods
			// 
			this.btnRefreshMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRefreshMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.btnRefreshMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.btnRefreshMods.Location = new System.Drawing.Point(507, 35);
			this.btnRefreshMods.Name = "btnRefreshMods";
			this.btnRefreshMods.Size = new System.Drawing.Size(135, 26);
			this.btnRefreshMods.TabIndex = 28;
			this.btnRefreshMods.Text = "Refresh mods list";
			this.ttCommon.SetToolTip(this.btnRefreshMods, "Notice: This will stop ALL of hl2.exe occurences from game directory!");
			this.btnRefreshMods.UseVisualStyleBackColor = false;
			this.btnRefreshMods.Click += new System.EventHandler(this.btnRefreshMods_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ModLauncher.Properties.Resources.background002;
			this.ClientSize = new System.Drawing.Size(654, 160);
			this.Controls.Add(this.btnRefreshMods);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnParams);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.Coral;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LeakNet - Mod Launcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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
		private System.Windows.Forms.Button srvStopButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button gameStopButton;
		private System.Windows.Forms.Button gameStartButton;
		private System.Windows.Forms.ToolTip ttAdditionalParams;
		private System.Windows.Forms.ToolTip ttChooseModification;
		private System.Windows.Forms.ToolTip ttCommon;
		private System.Windows.Forms.Button btnParams;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblGamePath;
		public System.Windows.Forms.ComboBox gameMapList;
		public System.Windows.Forms.ComboBox srvMapList;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		public System.Windows.Forms.ToolStripComboBox modList;
		private System.Windows.Forms.Button btnRefreshMods;
	}
}