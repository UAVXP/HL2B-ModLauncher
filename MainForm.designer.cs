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
			this.comButton = new System.Windows.Forms.Button();
			this.closeBut = new System.Windows.Forms.Button();
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
			this.move.Controls.Add(this.title);
			this.move.Controls.Add(this.minimize);
			this.move.Controls.Add(this.close);
			this.move.Location = new System.Drawing.Point(0, 0);
			this.move.Name = "move";
			this.move.Size = new System.Drawing.Size(352, 21);
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
			this.minimize.Location = new System.Drawing.Point(325, 6);
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
			this.close.Location = new System.Drawing.Point(338, 6);
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
			// comButton
			// 
			this.comButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.comButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.comButton.Location = new System.Drawing.Point(25, 60);
			this.comButton.Name = "comButton";
			this.comButton.Size = new System.Drawing.Size(173, 45);
			this.comButton.TabIndex = 19;
			this.comButton.Text = "Run modification";
			this.comButton.UseVisualStyleBackColor = false;
			this.comButton.Click += new System.EventHandler(this.comButton_Click);
			// 
			// closeBut
			// 
			this.closeBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
			this.closeBut.Location = new System.Drawing.Point(204, 60);
			this.closeBut.Name = "closeBut";
			this.closeBut.Size = new System.Drawing.Size(72, 45);
			this.closeBut.TabIndex = 20;
			this.closeBut.Text = "Close game";
			this.closeBut.UseVisualStyleBackColor = false;
			this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ModLauncher.Properties.Resources.background002;
			this.ClientSize = new System.Drawing.Size(352, 122);
			this.Controls.Add(this.closeBut);
			this.Controls.Add(this.comButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.modList);
			this.Controls.Add(this.move);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LeakNet - Bugreporter";
			this.Load += new System.EventHandler(this.BugreporterMain_Load);
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
		private System.Windows.Forms.ComboBox modList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button comButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button closeBut;
	}
}