using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random AiOptions = new Random();
        int Lost = 0;
        int Tied = 0;
        int Won = 0;
        
        private void LostOrWon()
        {
            int Lost = 0;
            int Tied = 0;
            int Won = 0;

            Youscore.Text = Won.ToString();
            Billyscore.Text = Lost.ToString();
            Tiedscore.Text = Tied.ToString();
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            int RandionAi = AiOptions.Next(1, 4);
            if (RandionAi == 1)
            {
                MessageBox.Show("Billy has choosen rock, You have tied");
                Tied = Tied + 1;
            }
            else if (RandionAi == 2)
            {
                MessageBox.Show("Billy has choosen paper, You have lost");
                Lost = Lost + 1;

                if (Lost == 3)
                {
                    MessageBox.Show("You have lost 3 times");
                    LostOrWon();
                }
            }
            else if (RandionAi == 3)
            {
                MessageBox.Show("Billy has choosen scissors, You have won");
                Won = Won + 1;

                if (Won == 3)
                {
                    MessageBox.Show("You have won 3 times");
                    LostOrWon();
                }

            }
            Youscore.Text = Won.ToString();
            Billyscore.Text = Lost.ToString();
            Tiedscore.Text = Tied.ToString();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int RandionAi = AiOptions.Next(1, 4);
            if (RandionAi == 1)
            {
                MessageBox.Show("Billy has choosen rock, You have won");
                Won = Won + 1;

                if (Won == 3)
                {
                    if (Won == 3)
                    {
                        MessageBox.Show("You have won 3 times");
                        LostOrWon();
                    }
                }
            }
            else if (RandionAi == 2)
            {
                MessageBox.Show("Billy has choosen paper, You have tied");
                Tied = Tied + 1;

            }
            else if (RandionAi == 3)
            {
                MessageBox.Show("Billy has choosen scissors, You have lost");
                Lost = Lost + 1;

                if (Lost == 3)
                {
                    MessageBox.Show("You have lost 3 times");
                    LostOrWon();
                }

                
            

            }
            Youscore.Text = Won.ToString();
            Billyscore.Text = Lost.ToString();
            Tiedscore.Text = Tied.ToString();
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            int RandionAi = AiOptions.Next(1, 4);
            if (RandionAi == 1)
            {
                MessageBox.Show("Billy has choosen rock, You have lost");
                Lost = Lost + 1;
                if (Lost == 3)
                {
                    MessageBox.Show("You have lost 3 times");
                }
            }
            else if (RandionAi == 2)
            {
                MessageBox.Show("Billy has choosen paper, You have won");
                Won = Won + 1;

                if (Won == 3)
                {
                    MessageBox.Show("You have won 3 times");
                }
            }
            else if (RandionAi == 3)
            {
                MessageBox.Show("Billy has choosen scissors, You have tied");
                Tied = Tied + 1;
            }
            Youscore.Text = Won.ToString();
            Billyscore.Text = Lost.ToString();
            Tiedscore.Text = Tied.ToString();
        }
    }
}
