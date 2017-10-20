using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

			horde1 = new AlienHorde(4, 10, 50, this);
			player1 = new Player(this.ClientSize.Height - 45, this);
		}

		private void playerTimer_Tick(object sender, EventArgs e)
		{
			player1.TickHandler();
		}

		private void alienTimer_Tick(object sender, EventArgs e)
		{
			horde1.Move();
		}

		private void FormSpaceInvaders_KeyDown(object sender, KeyEventArgs e)
		{
			player1.KeyDownHandler(e.KeyCode);
		}

		private void FormSpaceInvaders_KeyUp(object sender, KeyEventArgs e)
		{
			player1.KeyUpHandler(e.KeyCode);
		}
	}
}
