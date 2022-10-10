using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping
{
    public partial class Form1 : Form
    {
        public int vert = 4;
        public int hor = 4;
        public int score = 0;
        public Form1()
        {
            InitializeComponent();

            lose.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            platform.Top = backGround.Bottom - (backGround.Bottom / 10);
            loseLabel.Visible = false;
            loseLabel.Left = (backGround.Width / 2) - (loseLabel.Width / 2);
            loseLabel.Top = (backGround.Height / 2) - (loseLabel.Height / 2);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if ((e.KeyCode == Keys.R) && (lose.Enabled == false))
            {
                ball.Top = 50;
                ball.Left = 70;
                hor = 2;
                vert = 2;
                score = 0;
                loseLabel.Visible = false;
                lose.Enabled = true;
                counter.Text = "Ваш счёт: " + score;
            }

            if (e.KeyCode == Keys.W)
            {
                platform.Top += -30;
            }
            if (e.KeyCode == Keys.S)
            {
                platform.Top += 30;
            }
            if (e.KeyCode == Keys.A)
            {
                platform.Left += -30;
            }
            if (e.KeyCode == Keys.D)
            {
                platform.Left += 30;
            }
        }

        private void lose_Tick(object sender, EventArgs e)
        {
            /*platform.Left = Cursor.Position.X - (platform.Width / 2);*/
            ball.Left += hor;
            ball.Top += vert;

            if (ball.Left <= backGround.Left)
            {
                hor *= -1;
            }
            else if (ball.Right >= backGround.Right)
            {
                hor *= -1;
            }
            else if (ball.Top <= backGround.Top)
            {
                vert *= -1;
            }
            else if (ball.Bottom >= backGround.Bottom)
            {
                lose.Enabled = false;
                loseLabel.Visible = true;
            }

            if (ball.Bottom >= platform.Top && ball.Top <= platform.Bottom && ball.Right >= platform.Left && ball.Left <= platform.Right)
            {
                hor += 3;
                vert += 3;
                vert *= -1;
                score++;
                counter.Text = "Ваш счёт: " + score;
                
            }
        }

    }
}
