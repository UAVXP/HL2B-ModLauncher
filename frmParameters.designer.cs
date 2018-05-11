namespace ModLauncher
{
	partial class frmParameters
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParameters));
			this.title = new System.Windows.Forms.Label();
			this.move = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.minimize = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.PictureBox();
			this.ttAdditionalParams = new System.Windows.Forms.ToolTip(this.components);
			this.gameParametersText = new System.Windows.Forms.TextBox();
			this.srvParametersText = new System.Windows.Forms.TextBox();
			this.ttChooseModification = new System.Windows.Forms.ToolTip(this.components);
			this.ttCommon = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.move.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
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
			this.title.Size = new System.Drawing.Size(139, 11);
			this.title.TabIndex = 11;
			this.title.Text = "LeakNet - Additional Parameters";
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
			this.move.Size = new System.Drawing.Size(513, 21);
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
			this.minimize.Location = new System.Drawing.Point(486, 6);
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
			this.close.Location = new System.Drawing.Point(499, 6);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(9, 9);
			this.close.TabIndex = 9;
			this.close.TabStop = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// ttAdditionalParams
			// 
			this.ttAdditionalParams.ToolTipTitle = "Additional Parameters";
			// 
			// gameParametersText
			// 
			this.gameParametersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.gameParametersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gameParametersText.ForeColor = System.Drawing.Color.Silver;
			this.gameParametersText.Location = new System.Drawing.Point(37, 54);
			this.gameParametersText.Name = "gameParametersText";
			this.gameParametersText.Size = new System.Drawing.Size(446, 20);
			this.gameParametersText.TabIndex = 23;
			this.ttAdditionalParams.SetToolTip(this.gameParametersText, "Additional parameters for game");
			this.gameParametersText.TextChanged += new System.EventHandler(this.gameParametersText_TextChanged);
			this.gameParametersText.Leave += new System.EventHandler(this.gameParametersText_Leave);
			// 
			// srvParametersText
			// 
			this.srvParametersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.srvParametersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.srvParametersText.ForeColor = System.Drawing.Color.Silver;
			this.srvParametersText.Location = new System.Drawing.Point(37, 110);
			this.srvParametersText.Name = "srvParametersText";
			this.srvParametersText.Size = new System.Drawing.Size(446, 20);
			this.srvParametersText.TabIndex = 27;
			this.ttAdditionalParams.SetToolTip(this.srvParametersText, "Additional parameters for server");
			this.srvParametersText.TextChanged += new System.EventHandler(this.srvParametersText_TextChanged);
			this.srvParametersText.Leave += new System.EventHandler(this.srvParametersText_Leave);
			// 
			// ttChooseModification
			// 
			this.ttChooseModification.ToolTipTitle = "Modification";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.label2.Location = new System.Drawing.Point(22, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Game parameters:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(22, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "HLDS parameters:";
			// 
			// frmParameters
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ModLauncher.Properties.Resources.background002;
			this.ClientSize = new System.Drawing.Size(513, 160);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.srvParametersText);
			this.Controls.Add(this.gameParametersText);
			this.Controls.Add(this.move);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmParameters";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LeakNet - Additional Parameters";
			this.Shown += new System.EventHandler(this.frmParameters_Shown);
			this.move.ResumeLayout(false);
			this.move.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Panel move;
		private System.Windows.Forms.PictureBox minimize;
		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolTip ttAdditionalParams;
		private System.Windows.Forms.ToolTip ttChooseModification;
		private System.Windows.Forms.ToolTip ttCommon;
		public System.Windows.Forms.TextBox srvParametersText;
		public System.Windows.Forms.TextBox gameParametersText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}