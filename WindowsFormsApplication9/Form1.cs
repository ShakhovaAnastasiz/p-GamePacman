using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        private int width = 620;
        private int height = 600;
        private int sizem = 30;
        private int Score = 0;
        List<System.Windows.Forms.PictureBox> Dots = new List<System.Windows.Forms.PictureBox>();


        public Form1()
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
            this.KeyDown += new KeyEventHandler(Motion);

            Map();
            Seed();

            x.Enabled = true;

            x.Interval = 2000; //timer
            x.Start();

            Thread myThreadboo1 = new Thread(new ThreadStart(Boo1)); //another thread for ghost1
            myThreadboo1.Start();
            Thread myThreadboo2 = new Thread(new ThreadStart(Boo2)); //another thread for ghost2
            myThreadboo2.Start();
        }

        //****method for creating ghost1********
        private void Boo1()
        {

            boo1.Location = new Point(500, 15);
            while (pacman.Location.X != boo1.Location.X && pacman.Location.Y != boo1.Location.Y)
            {
                boo1.BackColor = Color.Black;
                boo1.Size = new Size(40, 40);
                boo1.Location = new Point(520, 15);
                for (int i = 1; i < 15; i++)
                {
                    boo1.Location = new Point(boo1.Location.X - 30, boo1.Location.Y);
                    Thread.Sleep(500);
                }
                for (int i = 1; i < 15; i++)
                {
                    boo1.Location = new Point(boo1.Location.X + 30, boo1.Location.Y);
                    Thread.Sleep(500);
                }
            }
        }
        //****method for creating ghost2********
        private void Boo2()
        {
            boo.Location = new Point(75, 360);
            while (pacman.Location.X != boo.Location.X && pacman.Location.Y != boo.Location.Y)
            {
                boo.BackColor = Color.Black;
                boo.Size = new Size(40, 40);
                boo.Location = new Point(45, 345);

                for (int i = 1; i < 12; i++)
                {
                    boo.Location = new Point(boo.Location.X + 30, boo.Location.Y);
                    Thread.Sleep(500);
                }
                for (int i = 1; i < 7; i++)
                {
                    boo.Location = new Point(boo.Location.X, boo.Location.Y - 30);
                    Thread.Sleep(500);
                }
                for (int i = 1; i < 7; i++)
                {
                    boo.Location = new Point(boo.Location.X, boo.Location.Y + 30);
                    Thread.Sleep(500);
                }
                for (int i = 1; i < 12; i++)
                {
                    boo.Location = new Point(boo.Location.X - 30, boo.Location.Y);
                    Thread.Sleep(500);
                }
                for (int i = 1; i < 5; i++)
                {
                    boo.Location = new Point(boo.Location.X, boo.Location.Y - 30);
                    Thread.Sleep(500);
                }
                for (int i = 1; i < 5; i++)
                {
                    boo.Location = new Point(boo.Location.X, boo.Location.Y + 30);
                    Thread.Sleep(500);
                }
            }
        }
        //****Exit for pacmen. Game over. Pacmen winner****
        private void GameOver()
        {
            if (pacman.Location.X + sizem > 500 && pacman.Location.Y + sizem > 530)
            {
                MessageBox.Show("You win! Your Score: " + Score);
                this.Close();

            }
        }
        //****Game over. Pacmen bumped into the ghost********
        private void Boo1Clash()
        {
            if (boo1.Location.X <= pacman.Location.X && boo1.Location.Y <= pacman.Location.Y && boo1.Location.X + 40 >= pacman.Location.X + sizem && boo1.Location.Y + 40 >= pacman.Location.Y + sizem)
            {
                MessageBox.Show("You are loser. Score:" + Score);
                this.Close();
            }
        }
        private void Boo2Clash()
        {
            if (boo.Location.X <= pacman.Location.X && boo.Location.Y <= pacman.Location.Y && boo.Location.X + 40 >= pacman.Location.X + sizem && boo.Location.Y + 40 >= pacman.Location.Y + sizem)
            {
                MessageBox.Show("You are loser. Score:" + Score);
                this.Close();
            }
        }
        //**** pacmen pick up coins for Score******
        private void Clash()
        {
            foreach (System.Windows.Forms.PictureBox i in Dots.ToArray())
            {
                if (i.Location.X >= pacman.Location.X && i.Location.Y >= pacman.Location.Y && i.Location.X <= pacman.Location.X + sizem && i.Location.Y <= pacman.Location.Y + sizem)
                {
                    Dots.Remove(i);
                    i.Dispose();

                    lblScore.Text = "Score:" + ++Score;
                }
            }
        }
        // ****Coins generation****
        private void Seed()
        {

            for (int j = 0; j < (height / sizem); j++)
            {
                for (int i = 0; i < (width / sizem) - 1; i++)
                {
                    PictureBox dot = new PictureBox();
                    dot.BackColor = Color.White;
                    dot.Size = new Size(2, 2);
                    dot.Location = new Point(sizem * i, sizem * j);
                    this.Controls.Add(dot);
                    Dots.Add(dot);
                }
            }
        }
        //*****Map generation******
        private void Map()
        {

            borderL.Size = new Size(2, 560);
            borderL.BackColor = Color.White;
            borderL.Location = new Point(0, 0);
            borderR.Size = new Size(2, 560);
            borderR.BackColor = Color.White;
            borderR.Location = new Point(560, 0);
            borderU.Size = new Size(560, 2);
            borderU.BackColor = Color.White;
            borderU.Location = new Point(0, 0);
            borderD.Size = new Size(560, 2);
            borderD.BackColor = Color.White;
            borderD.Location = new Point(0, 560);

            PictureBox barrier1 = new PictureBox();
            barrier1.Size = new Size(30, 210);
            barrier1.BackColor = Color.White;
            barrier1.Location = new Point(315, 75);
            this.Controls.Add(barrier1);

            PictureBox barrier2 = new PictureBox();
            barrier2.Size = new Size(385, 30);
            barrier2.BackColor = Color.White;
            barrier2.Location = new Point(45, 405);
            this.Controls.Add(barrier2);

            exit.Size = new Size(60, 30);
            exit.Location = new Point(500, 530);
            this.Controls.Add(exit);
        }
        //***Pacman movement*****
        private void Motion(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    pacman.BackgroundImage = Properties.Resources.Pacman as Bitmap;
                    if (pacman.Location.X >= 15 && pacman.Location.X <= 60 && pacman.Location.Y >= 405 && pacman.Location.Y < 435)
                    {
                        break;
                    }
                    else
                        if (pacman.Location.X >= 285 && pacman.Location.X <= 315 && pacman.Location.Y >= 75 && pacman.Location.Y < 285)
                        {
                            break;
                        }
                    else
                        if (pacman.Location.X < 530 - sizem)
                        {
                            pacman.Location = new Point(pacman.Location.X + sizem, pacman.Location.Y);
                        }
                    break;
                case "Left":
                    pacman.BackgroundImage = Properties.Resources.PacmanL as Bitmap;
                    if (pacman.Location.X >= 15 && pacman.Location.X < 460 && pacman.Location.Y >= 405 && pacman.Location.Y < 435)
                    {
                        break;
                    }
                    else
                        if (pacman.Location.X >= 315 && pacman.Location.X <= 345 && pacman.Location.Y >= 75 && pacman.Location.Y < 285)
                        {
                            break;
                        }
                    else
                       if (pacman.Location.X > sizem)
                        {
                            pacman.Location = new Point(pacman.Location.X - sizem, pacman.Location.Y);
                        }
                    break;
                case "Up":
                    pacman.BackgroundImage = Properties.Resources.PacmanU as Bitmap;
                    if (pacman.Location.X >= 45 && pacman.Location.X <= 430 && pacman.Location.Y >= 405 && pacman.Location.Y <= 465)
                    {
                        break;
                    }
                    else
                        if (pacman.Location.X >= 315 && pacman.Location.X < 345 && pacman.Location.Y >= 75 && pacman.Location.Y < 315)
                        {
                            break;
                        }
                    else
                        if (pacman.Location.Y > sizem)
                        {
                            pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - sizem);
                        }
                    break;
                case "Down":
                    pacman.BackgroundImage = Properties.Resources.PacmanD as Bitmap;
                    if (pacman.Location.X >= 45 && pacman.Location.X <= 430 && pacman.Location.Y >= 375 && pacman.Location.Y <= 435)
                    {
                        break;
                    }
                    else
                        if (pacman.Location.X >= 315 && pacman.Location.X < 345 && pacman.Location.Y >= 45 && pacman.Location.Y <= 285)
                        {
                            break;
                        }

                    else
                        if (pacman.Location.Y < 530 - sizem)
                        {
                            pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + sizem);
                        }
                    break;
            }
            Clash();
            GameOver();
            Boo2Clash();
            Boo1Clash();
        }
    }
}
