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
	abstract class Entity	//BIG TODO-TODO
	{
		public Form formItBelongsTo;
		public Control ImageBox;
	}
	class LaserBullet
	{
		Form formItBelongsTo;
		public Control ImageBox;
		bool isGoingUp;
		int Speed { get; set; }

		public LaserBullet(Control control, Form form, bool IsGoingUp, Color color)
		{
			Speed = 5;
			this.isGoingUp = IsGoingUp;
			//Initialising the box
			ImageBox = new PictureBox
			{
				Top = control.Top + control.Height / 2,
				Left = control.Left + control.Width / 2,
				BackColor = color,
				Size = new Size(3, 15),
				TabStop = false
			};
			//Adding the box to the form
			form.Controls.Add(ImageBox);
			formItBelongsTo = form;
		}
		public void TickHandler()
		{
			if (isGoingUp) ImageBox.Top -= Speed;
			else ImageBox.Top += Speed;
		}
		public bool IntersectsWith(Player obj)
		{
			return ImageBox.Bounds.IntersectsWith(obj.ImageBox.Bounds);
		}
	}
	class Player
	{
		Form formItBelongsTo;
		public List<LaserBullet> Lasers;   //Lasers active
		public int Speed { get; set; }
		public Control ImageBox;
		//Controls
		public Keys Right, Left, Fire;
		public bool isRightPressed = false, isLeftPressed = false;

		//Use this for 2 or more players
		public Player(Keys left, Keys right, Keys fire, int yPos, Form form)
		{
			//Initialising the variables
			Speed = 2;
			//Initialising the laser list
			Lasers = new List<LaserBullet>();
			//Initialising the controls
			Left = left;
			Right = right;
			Fire = fire;
			//Initialising the box
			ImageBox = new PictureBox
			{
				BackColor = Color.Blue,
				Location = new Point(form.ClientSize.Width / 2 - 50, yPos),
				Size = new Size(50, 30),
				TabStop = false
			};
			//Adding the box to the form
			form.Controls.Add(ImageBox);
			formItBelongsTo = form;
		}
		//Use this for only 1 player
		public Player(int yPos, Form form) : this(Keys.A, Keys.D, Keys.Space, yPos, form) { }
		public void TickHandler()
		{
			if (isRightPressed)
				ImageBox.Left += Speed;
			if (isLeftPressed)
				ImageBox.Left -= Speed;
			foreach (LaserBullet item in Lasers)
				item.TickHandler();
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
			Lasers.Add(new LaserBullet(this.ImageBox, formItBelongsTo, true, Color.Cyan));
		}
	}
	class AlienHorde
	{
		Form formItBelongsTo;       //Doesn't need explanation
		public List<Control> AlienBoxList;	//Aliens
		public List<LaserBullet> Lasers;   //Lasers active
		public int AlienCount { get; private set; }
		public AlienHorde(int rows, int collumns, Form form)
		{
			int spaceBetweenAliens = 15;

			int width = 25;
			int height = 20;

			int startingX = form.ClientSize.Width / 2 - ((width + spaceBetweenAliens) * collumns) / 2;
			int xPos = startingX;   //Left coordinate where the row of aliens start spawning
			int yPos = 35;          //Top coordinate where the first row of aliens start spawning

			AlienBoxList = new List<Control>();
			AlienCount = rows * collumns;
			//Lasers
			Lasers = new List<LaserBullet>();
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < collumns; j++)
				{
					//Declaring a new box
					Control temp = new PictureBox
					{
						BackColor = Color.Lime,
						Location = new Point(xPos, yPos),
						Size = new Size(width, height),
						TabStop = false
					};
					//Adding the box to the list
					AlienBoxList.Add(temp);
					xPos += width + spaceBetweenAliens;
					//Adding the box to the form
					form.Controls.Add(temp);
					formItBelongsTo = form;
				}
				xPos = startingX;
				yPos += height + spaceBetweenAliens;
			}
		}
		public void TickHandler()
		{
			foreach (Control alien in AlienBoxList)
				alien.Top = alien.Location.Y + 2;
			Random rnd = new Random();
			Fire();
		}
		public void Fire()
		{
			Random rnd = new Random();
			for (int i = 0; i < 5; i++)
			{
				if (AlienCount == 0)
					break;
				if (AlienCount == 1)
					i = 4;
				Lasers.Add(new LaserBullet(AlienBoxList[rnd.Next(0, AlienCount - 1)], formItBelongsTo, false, Color.Red));
			}
		}
		public bool ItHitAnyAlien(LaserBullet obj)
		{
			foreach (Control item in AlienBoxList)
				if (item.Bounds.IntersectsWith(obj.ImageBox.Bounds))
				{
					formItBelongsTo.Controls[formItBelongsTo.Controls.IndexOf(item)].Dispose();
					AlienBoxList.Remove(item);
					AlienCount--;
					return true;
				}
			return false;
		}
	}
}