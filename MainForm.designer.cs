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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.title = new System.Windows.Forms.Label();
			this.move = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.minimize = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.PictureBox();
			this.modList = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.additionalParamsBut = new System.Windows.Forms.Button();
			this.gameParametersText = new System.Windows.Forms.TextBox();
			this.srvStartButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.srvStopButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gameStopButton = new System.Windows.Forms.Button();
			this.gameStartButton = new System.Windows.Forms.Button();
			this.srvParametersText = new System.Windows.Forms.TextBox();
			this.move.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.move.Size = new System.Drawing.Size(650, 21);
			this.move.TabIndex = 12;
			this.move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::ModLauncher.Properties.Resources.game;
			this.pictureBox1.Location = new System.Drawing.Point(5, 4);
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
			this.minimize.Location = new System.Drawing.Point(623, 6);
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
			this.close.Location = new System.Drawing.Point(636, 6);
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
			this.modList.Location = new System.Drawing.Point(137, 33);
			this.modList.Name = "modList";
			this.modList.Size = new System.Drawing.Size(139, 21);
			this.modList.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.label2.Location = new System.Drawing.Point(24, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Choose modification:";
			// 
			// additionalParamsBut
			// 
			this.additionalParamsBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.additionalParamsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.additionalParamsBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.additionalParamsBut.Image = global::ModLauncher.Properties.Resources.arrowDown;
			this.additionalParamsBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.additionalParamsBut.Location = new System.Drawing.Point(143, 107);
			this.additionalParamsBut.Name = "additionalParamsBut";
			this.additionalParamsBut.Size = new System.Drawing.Size(133, 23);
			this.additionalParamsBut.TabIndex = 21;
			this.additionalParamsBut.Text = "Additional parameters";
			this.additionalParamsBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.additionalParamsBut.UseVisualStyleBackColor = false;
			this.additionalParamsBut.Click += new System.EventHandler(this.additionalParamsBut_Click);
			// 
			// gameParametersText
			// 
			this.gameParametersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.gameParametersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gameParametersText.ForeColor = System.Drawing.Color.Silver;
			this.gameParametersText.Location = new System.Drawing.Point(282, 144);
			this.gameParametersText.Name = "gameParametersText";
			this.gameParametersText.Size = new System.Drawing.Size(171, 20);
			this.gameParametersText.TabIndex = 22;
			this.gameParametersText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameParametersText_KeyDown);
			this.gameParametersText.Leave += new System.EventHandler(this.parametersText_Leave);
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
			this.groupBox1.Controls.Add(this.srvStopButton);
			this.groupBox1.Controls.Add(this.srvStartButton);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.groupBox1.Location = new System.Drawing.Point(459, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(171, 103);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dedicated server (hlds.exe)";
			// 
			// srvStopButton
			// 
			this.srvStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.srvStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.srvStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.srvStopButton.Location = new System.Drawing.Point(21, 57);
			this.srvStopButton.Name = "srvStopButton";
			this.srvStopButton.Size = new System.Drawing.Size(133, 32);
			this.srvStopButton.TabIndex = 24;
			this.srvStopButton.Text = "Stop";
			this.srvStopButton.UseVisualStyleBackColor = false;
			this.srvStopButton.Click += new System.EventHandler(this.srvStopButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.gameStopButton);
			this.groupBox2.Controls.Add(this.gameStartButton);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.groupBox2.Location = new System.Drawing.Point(282, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(171, 103);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game (hl2.exe)";
			// 
			// gameStopButton
			// 
			this.gameStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.gameStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gameStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.gameStopButton.Location = new System.Drawing.Point(21, 57);
			this.gameStopButton.Name = "gameStopButton";
			this.gameStopButton.Size = new System.Drawing.Size(133, 32);
			this.gameStopButton.TabIndex = 24;
			this.gameStopButton.Text = "Stop";
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
			// srvParametersText
			// 
			this.srvParametersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.srvParametersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.srvParametersText.ForeColor = System.Drawing.Color.Silver;
			this.srvParametersText.Location = new System.Drawing.Point(459, 144);
			this.srvParametersText.Name = "srvParametersText";
			this.srvParametersText.Size = new System.Drawing.Size(171, 20);
			this.srvParametersText.TabIndex = 26;
			this.srvParametersText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srvParametersText_KeyDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ModLauncher.Properties.Resources.background002;
			this.ClientSize = new System.Drawing.Size(650, 182);
			this.Controls.Add(this.srvParametersText);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gameParametersText);
			this.Controls.Add(this.additionalParamsBut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.modList);
			this.Controls.Add(this.move);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Panel move;
		private System.Windows.Forms.PictureBox minimize;
		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.ComboBox modList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button additionalParamsBut;
		private System.Windows.Forms.TextBox gameParametersText;
		private System.Windows.Forms.Button srvStartButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button srvStopButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button gameStopButton;
		private System.Windows.Forms.Button gameStartButton;
		private System.Windows.Forms.TextBox srvParametersText;
	}
}