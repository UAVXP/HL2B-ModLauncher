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
			this.ttAdditionalParams = new System.Windows.Forms.ToolTip(this.components);
			this.gameParametersText = new System.Windows.Forms.TextBox();
			this.srvParametersText = new System.Windows.Forms.TextBox();
			this.ttChooseModification = new System.Windows.Forms.ToolTip(this.components);
			this.ttCommon = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.gameParametersText.Location = new System.Drawing.Point(34, 29);
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
			this.srvParametersText.Location = new System.Drawing.Point(34, 85);
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
			this.label2.Location = new System.Drawing.Point(19, 13);
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
			this.label1.Location = new System.Drawing.Point(19, 69);
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
			this.ClientSize = new System.Drawing.Size(517, 129);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.srvParametersText);
			this.Controls.Add(this.gameParametersText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmParameters";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LeakNet - Additional Parameters";
			this.Shown += new System.EventHandler(this.frmParameters_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip ttAdditionalParams;
		private System.Windows.Forms.ToolTip ttChooseModification;
		private System.Windows.Forms.ToolTip ttCommon;
		public System.Windows.Forms.TextBox srvParametersText;
		public System.Windows.Forms.TextBox gameParametersText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}