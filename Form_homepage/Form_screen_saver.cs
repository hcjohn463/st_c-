using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_homepage
{
    public partial class Form_screen_saver : Form
    {
        public Form_screen_saver()
        {
            InitializeComponent();
            picturebox_screen_saver.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form_screen_saver_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            this.TopMost= true;
            moveTimer.Interval = 30;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();

        }
        private Point mouseLocation;
        private int offset = 5;
        private int motion = 2; //right_down

        private void Form_screen_saver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 10 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 10)
                {
                    this.Close();
                    Cursor.Show();
                }
            }

            // Update current mouse location
            mouseLocation = e.Location;

        }

        private void Form_screen_saver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Cursor.Show();
        }

        private void Form_screen_saver_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
            Cursor.Show();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            // Move text to new location
            if(motion == 1)
            {
                move_left_up();
            }
            else if(motion == 2)
            {
                move_right_up();
            }
            else if(motion == 3)
            {
                move_right_down();
            }
            else if(motion == 4)
            {
                move_left_down();
            }
        }
        private void move_right_down() //state 3
        {
            picturebox_screen_saver.Left += offset;
            picturebox_screen_saver.Top += offset;
            if(picturebox_screen_saver.Left >= (Bounds.Width - picturebox_screen_saver.Width))
            {
                motion = 4;
            }
            else if(picturebox_screen_saver.Top >= (Bounds.Height - picturebox_screen_saver.Height))
            {
                motion = 2;
            }
        }
        private void move_left_down() //state 4
        {
            picturebox_screen_saver.Left -= offset;
            picturebox_screen_saver.Top += offset;
            if (picturebox_screen_saver.Left <= 0)
            {
                motion = 3;
            }
            else if (picturebox_screen_saver.Top >= (Bounds.Height - picturebox_screen_saver.Height))
            {
                motion = 1;
            }
        }
        private void move_left_up() //state 1
        {
            picturebox_screen_saver.Left -= offset;
            picturebox_screen_saver.Top -= offset;
            if (picturebox_screen_saver.Left <= 0)
            {
                motion = 2;
            }
            else if (picturebox_screen_saver.Top <= 0)
            {
                motion = 4;
            }
        }
        private void move_right_up() //state 2
        {
            picturebox_screen_saver.Left += offset;
            picturebox_screen_saver.Top -= offset;
            if (picturebox_screen_saver.Left >= (Bounds.Width - picturebox_screen_saver.Width))
            {
                motion = 1;
            }
            else if (picturebox_screen_saver.Top <= 0)
            {
                motion = 3;
            }
        }
    }
}
