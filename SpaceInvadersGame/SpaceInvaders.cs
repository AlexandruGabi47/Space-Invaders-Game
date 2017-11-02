using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvadersComponents;

namespace SpaceInvadersGame
{
	public partial class FormSpaceInvaders : Form
	{
		AlienHorde horde1;
		Player player1;
		public FormSpaceInvaders()
		{
			InitializeComponent();

			ClientSize = new Size(1366,700);
			this.WindowState = FormWindowState.Maximized;

			horde1 = new AlienHorde(4, 15, this);
			player1 = new Player(this.ClientSize.Height - 100, this);

			BottomLabel.Size = new Size(ClientSize.Width, BottomLabel.Size.Height);
			BottomLabel.Location = new Point(0, ClientSize.Height - BottomLabel.Height + 10);
			DebugLabel.Location = new Point(15, BottomLabel.Location.Y + 13);
			DebugLabel.BringToFront();

			StatusLabel.Visible = false;
			StatusLabel.Left = ClientSize.Width / 2 - StatusLabel.Width / 2;
			StatusLabel.Top = ClientSize.Height / 2 - StatusLabel.Height / 2;
		}

		private void OutOfBoundsChecker_Tick(object sender, EventArgs e)
		{
			DebugLabel.Text = $"Controls: {Controls.Count}; ";
			for (int i = 0; i < Controls.Count; i++)
			{
				if (Controls[i].IsOutOfBounds(this))
				{
					Controls[i].Dispose();
					DebugLabel.Text += "Removed a control";
					break;
				}
			}
			//Calling the garbage collector
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			//Moving the alien lasers
			foreach (LaserBullet item in horde1.Lasers)
				item.TickHandler();
			if (player1 != null)
			{
				//Moves the player and the lasers
				player1.TickHandler();
				//Checking if any player laser hit any alien then destroys both the laser and the alien
				foreach (LaserBullet item in player1.Lasers)
					if (horde1.ItHitAnyAlien(item))
					{
						item.ImageBox.Dispose();
						player1.Lasers.RemoveAt(player1.Lasers.IndexOf(item));
						break;
					}

				//Checking if any alien laser hit the player
				foreach (LaserBullet item in horde1.Lasers)
				{
					if (player1.ImageBox.Bounds.IntersectsWith(item.ImageBox.Bounds))
					{
						player1.ImageBox.Dispose();
						for (int i = 0; i < player1.Lasers.Count;)
						{
							player1.Lasers[i].ImageBox.Dispose();
							player1.Lasers.RemoveAt(i);
						}
						player1 = null;

						StatusLabel.Visible = true;
						break;
					}
				}
				//Checking if there are any aliens left
				if (horde1.AlienCount == 0)
				{
					StatusLabel.Text = "YOU WON";
					StatusLabel.ForeColor = Color.Lime;
					StatusLabel.Visible = true;
				}
			}
		}

		private void AlienTimer_Tick(object sender, EventArgs e)
		{
			if (horde1 != null)
				horde1.TickHandler();
		}

		private void FormSpaceInvaders_KeyDown(object sender, KeyEventArgs e)
		{
			if (player1 != null)
				player1.KeyDownHandler(e.KeyCode);
		}

		private void FormSpaceInvaders_KeyUp(object sender, KeyEventArgs e)
		{
			if (player1 != null)
				player1.KeyUpHandler(e.KeyCode);
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void resolutionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//todo
		}
	}

	public static class Extensions
	{
		public static bool IsOutOfBounds(this Control control, Form form)
		{
			return control.Top + control.Height < 0 || control.Top > form.ClientSize.Height;
		}
	}
}