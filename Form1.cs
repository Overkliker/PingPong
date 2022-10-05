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

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lose_Tick(object sender, EventArgs e)
        {
            platform.Left = Cursor.Position.X - (platform.Width / 2);
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
            }

            if (ball.Bottom >= platform.Top && ball.Top <= platform.Bottom && ball.Right >= platform.Left && ball.Left <= platform.Right)
            {
                hor += 3;
                vert += 3;
                vert *= -1;
            }
        }
    }
}
