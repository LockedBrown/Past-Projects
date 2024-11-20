using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace GameTest_3
{
    class Meteor
    {
        public PictureBox aMeteor;
        int speed = 0;
        Random random = new Random();
        public Boolean isDisposed = false;
        int randomY = 0;
        int CashToGive = 0;
        int ScoreToGive = 0;

        public Meteor(Form form, int speedOne, int speedTwo)
        {
            aMeteor = new PictureBox();
            // Width
            aMeteor.Width = 40;
            // Height
            aMeteor.Height = 30;

            // Colour
            aMeteor.Image = Properties.Resources.MeteorImage;
            aMeteor.SizeMode = PictureBoxSizeMode.Zoom;
            // Speed of the Meteor
            speed = random.Next(speedOne, speedTwo);
            randomY = random.Next(5, 50);
            // X Pos
            aMeteor.Left = 735;
            // Y Pos
            aMeteor.Top = random.Next(20, 350) + randomY;

            form.Controls.Add(aMeteor);
        }
        public int CashGiven()
        {
            CashToGive = 100;
            return CashToGive;
        }

        public int ScoreGiven()
        {
            ScoreToGive = 100;
            return ScoreToGive;
        }
        public void MoveMeteor(Form f, bool IsPaused)
        {
            if (IsPaused)
            {
                aMeteor.Left = aMeteor.Left;
            }
            else
            {
                aMeteor.Left -= speed;
            }
        }

    }
}
