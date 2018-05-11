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
            this.title = new System.Windows.Forms.Label();
            this.move = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.modList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srvStartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srvMapList = new System.Windows.Forms.ComboBox();
            this.srvStopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gameMapList = new System.Windows.Forms.ComboBox();
            this.gameStopButton = new System.Windows.Forms.Button();
            this.gameStartButton = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ttAdditionalParams = new System.Windows.Forms.ToolTip(this.components);
            this.ttChooseModification = new System.Windows.Forms.ToolTip(this.components);
            this.ttCommon = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGamePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.title.Location = new System.Drawing.Point(23, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(105, 11);
            this.title.TabIndex = 11;
            this.title.Text = "LeakNet - Mod Launcher";
            // 
            // move
            // 
            this.move.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.move.BackColor = System.Drawing.Color.Transparent;
            this.move.BackgroundImage = global::ModLauncher.Properties.Resources.background003;
            this.move.Controls.Add(this.pictureBox1);
            this.move.Controls.Add(this.minimize);
            this.move.Controls.Add(this.close);
            this.move.Controls.Add(this.title);
            this.move.Location = new System.Drawing.Point(0, 0);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(652, 21);
            this.move.TabIndex = 12;
            this.move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ModLauncher.Properties.Resources.game;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = global::ModLauncher.Properties.Resources.minimize001;
            this.minimize.Location = new System.Drawing.Point(625, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(7, 9);
            this.minimize.TabIndex = 13;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::ModLauncher.Properties.Resources.close001;
            this.close.Location = new System.Drawing.Point(638, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(9, 9);
            this.close.TabIndex = 9;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // modList
            // 
            this.modList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.modList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modList.ForeColor = System.Drawing.Color.Silver;
            this.modList.FormattingEnabled = true;
            this.modList.Location = new System.Drawing.Point(373, 27);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(189, 21);
            this.modList.TabIndex = 13;
            this.ttChooseModification.SetToolTip(this.modList, "Here you can choose modification that you want to run");
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(260, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose modification:";
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
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.srvMapList);
            this.groupBox1.Controls.Add(this.srvStopButton);
            this.groupBox1.Controls.Add(this.srvStartButton);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.groupBox1.Location = new System.Drawing.Point(263, 62);
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
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.gameMapList);
            this.groupBox2.Controls.Add(this.gameStopButton);
            this.groupBox2.Controls.Add(this.gameStartButton);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
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
            this.btnParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.btnParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.btnParams.Location = new System.Drawing.Point(508, 68);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(132, 28);
            this.btnParams.TabIndex = 25;
            this.btnParams.Text = "Game Parameters";
            this.ttCommon.SetToolTip(this.btnParams, "Notice: This will stop ALL of hl2.exe occurences from game directory!");
            this.btnParams.UseVisualStyleBackColor = false;
            this.btnParams.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.btnRefresh.Location = new System.Drawing.Point(568, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 21);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 165);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(652, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ModLauncher.Properties.Resources.background002;
            this.ClientSize = new System.Drawing.Size(652, 187);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.move);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modList);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeakNet - Mod Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.move.ResumeLayout(false);
            this.move.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Panel move;
		private System.Windows.Forms.PictureBox minimize;
		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button srvStartButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button srvStopButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button gameStopButton;
		private System.Windows.Forms.Button gameStartButton;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.ToolTip ttAdditionalParams;
		private System.Windows.Forms.ToolTip ttChooseModification;
		private System.Windows.Forms.ToolTip ttCommon;
		private System.Windows.Forms.Button btnParams;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblGamePath;
		public System.Windows.Forms.ComboBox modList;
		public System.Windows.Forms.ComboBox gameMapList;
		public System.Windows.Forms.ComboBox srvMapList;
	}
}