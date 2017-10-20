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

namespace SpaceInvadersComponents
{
	class AlienHorde
	{
		List<Control> AlienBoxList;
		int AlienCount;
		public AlienHorde(int rows, int collumns, int startingX, Form form)
		{
			int xPos = startingX;
			int yPos = 20;
			int spaceBetweenAliens = 20;
			AlienBoxList = new List<Control>();
			AlienCount = rows * collumns;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < collumns; j++)
				{
					//Declaring a new box
					Control temp = new PictureBox();
					temp.BackColor = Color.Lime;
					temp.Location = new Point(xPos, yPos);
					temp.Name = "Alien" + (j + i + 1).ToString();
					temp.Size = new Size(45, 35);
					temp.TabIndex = j + i;
					temp.TabStop = false;
					//Adding the box to the list
					AlienBoxList.Add(temp);
					xPos += 45 + spaceBetweenAliens;
					//Adding the box to the form
					form.Controls.Add(temp);
				}
				xPos = startingX;
				yPos += 35 + spaceBetweenAliens;
			}
		}

		public void Move()
		{
			foreach (Control alien in AlienBoxList)
			{
				alien.Location = new Point(alien.Location.X, alien.Location.Y + 2);
			}
		}
	}
	class Player
	{
		public int Health { get; private set; }
		public int Speed { get; set; }
		//Controls
		Keys Right, Left, Fire;
		bool isRightPressed = false, isLeftPressed = false;

		Control ImageBox;		//Image of the player, necessary
		//Label ScoreBox;			//optional
		
		public Player(Keys left, Keys right, Keys fire, int yPos, Form form)
		//Use this for 2 or more players
		{
			//Initialising the variables
			Health = 3;
			Speed = 2;
			//Initialising the controls
			Left = left;
			Right = right;
			Fire = fire;
			//Initialising the box
			ImageBox = new PictureBox();
			ImageBox.BackColor = Color.Blue;
			ImageBox.Location = new Point(100, yPos);
			ImageBox.Name = "Player";
			ImageBox.Size = new Size(50, 30);
			ImageBox.TabStop = false;
			//Adding the box to the form
			form.Controls.Add(ImageBox);
		}
		public Player(int yPos, Form form) : this(Keys.A, Keys.D, Keys.Space, yPos, form)
		//Use this for only 1 player
		{

		}
		public void TickHandler()
		{
			if (isRightPressed)
				ImageBox.Left += Speed;
			if (isLeftPressed)
				ImageBox.Left -= Speed;
		}
		public void KeyDownHandler(Keys key)
		{
			if (key == Left)
				isLeftPressed = true;
			if (key == Right)
				isRightPressed = true;
		}
		public void KeyUpHandler(Keys key)
		{
			if (key == Left)
				isLeftPressed = false;
			if (key == Right)
				isRightPressed = false;
			if (key == Fire)
				FireLaser();
		}
		public void FireLaser()
		{

		}
	}
	class LaserBullet
	{
		Control ImageBox;
		bool isGoingUp = true;
		public LaserBullet(Player player, Form form)
		{
			//Initialising the box
			ImageBox = new PictureBox();
			ImageBox.BackColor = Color.Blue;
			//ImageBox.Location = new Point(100, yPos);
			ImageBox.Name = "Player";
			ImageBox.Size = new Size(50, 30);
			ImageBox.TabStop = false;
			//Adding the box to the form
			form.Controls.Add(ImageBox);
		}
	}
}
