using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GameTest_3
{
    class bullet
    {
        public PictureBox abullet;
        private int xpos = 0, ypos = 0;
        public Boolean isDisposed = false;
        

        // Bullet BluePrint
        public bullet(Form form, PictureBox player)
        {
            // New Picture Instance
            abullet = new PictureBox();
            abullet.BringToFront();
            // Width
            abullet.Width = 10;
            // Height
            abullet.Height = 3;
            // Color
            abullet.BackColor = Color.Yellow;
            // makes it invisible
            abullet.Visible = false;
            // Y Pos
            ypos = player.Top + (player.Height / 2);
            // X Pos
            xpos = player.Left + 5;

            // settings the bullet location
            abullet.Location = new Point(xpos, ypos);
            form.Controls.Add(abullet);
        }
        public void moveBullet(Form f, bool IsPaused, int BulletSpeed)
        {
            abullet.Visible = true;
            
            if (IsPaused)
            {
                xpos = xpos;
            }
            else
            {
                xpos += BulletSpeed;
            }

            if (xpos >= 700)
            {
                abullet.Dispose();
                isDisposed = true;
            }
            abullet.Location = new Point(xpos, ypos);
        }


    }
}
