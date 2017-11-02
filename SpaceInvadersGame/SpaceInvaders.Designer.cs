namespace SpaceInvadersGame
{
	partial class FormSpaceInvaders
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
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.alienTimer = new System.Windows.Forms.Timer(this.components);
			this.OutOfBoundsChecker = new System.Windows.Forms.Timer(this.components);
			this.DebugLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BottomLabel = new System.Windows.Forms.Label();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 13;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// alienTimer
			// 
			this.alienTimer.Enabled = true;
			this.alienTimer.Interval = 1000;
			this.alienTimer.Tick += new System.EventHandler(this.AlienTimer_Tick);
			// 
			// OutOfBoundsChecker
			// 
			this.OutOfBoundsChecker.Enabled = true;
			this.OutOfBoundsChecker.Interval = 50;
			this.OutOfBoundsChecker.Tick += new System.EventHandler(this.OutOfBoundsChecker_Tick);
			// 
			// DebugLabel
			// 
			this.DebugLabel.AutoSize = true;
			this.DebugLabel.BackColor = System.Drawing.Color.Yellow;
			this.DebugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DebugLabel.ForeColor = System.Drawing.Color.Navy;
			this.DebugLabel.Location = new System.Drawing.Point(12, 536);
			this.DebugLabel.Name = "DebugLabel";
			this.DebugLabel.Size = new System.Drawing.Size(95, 17);
			this.DebugLabel.TabIndex = 0;
			this.DebugLabel.Text = "DebugLabel";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolutionToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// resolutionToolStripMenuItem
			// 
			this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
			this.resolutionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.resolutionToolStripMenuItem.Text = "Resolution";
			this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
			// 
			// BottomLabel
			// 
			this.BottomLabel.BackColor = System.Drawing.Color.Yellow;
			this.BottomLabel.Location = new System.Drawing.Point(-104, 481);
			this.BottomLabel.Name = "BottomLabel";
			this.BottomLabel.Size = new System.Drawing.Size(910, 45);
			this.BottomLabel.TabIndex = 1;
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
			this.StatusLabel.Font = new System.Drawing.Font("Gabriola", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.StatusLabel.Location = new System.Drawing.Point(287, 204);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(360, 160);
			this.StatusLabel.TabIndex = 3;
			this.StatusLabel.Text = "YOU DIED";
			// 
			// FormSpaceInvaders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.BottomLabel);
			this.Controls.Add(this.DebugLabel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormSpaceInvaders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSpaceInvaders_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormSpaceInvaders_KeyUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.Timer alienTimer;
		private System.Windows.Forms.Timer OutOfBoundsChecker;
		private System.Windows.Forms.Label DebugLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
		private System.Windows.Forms.Label BottomLabel;
		private System.Windows.Forms.Label StatusLabel;
	}
}

