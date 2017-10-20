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
			this.playerTimer = new System.Windows.Forms.Timer(this.components);
			this.alienTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// playerTimer
			// 
			this.playerTimer.Enabled = true;
			this.playerTimer.Interval = 15;
			this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
			// 
			// alienTimer
			// 
			this.alienTimer.Enabled = true;
			this.alienTimer.Interval = 1500;
			this.alienTimer.Tick += new System.EventHandler(this.alienTimer_Tick);
			// 
			// FormSpaceInvaders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(730, 434);
			this.Name = "FormSpaceInvaders";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSpaceInvaders_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormSpaceInvaders_KeyUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer playerTimer;
		private System.Windows.Forms.Timer alienTimer;
	}
}

