using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true; // true = X turn; false = Y turn
        int turn_count = 0;
        int Draw = 0;
        int X_Wins = 0;
        int O_Wins = 0;


        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the game of tic tac toe, the players have to get 3 X's or O's in any direction to win.", "About", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            { 
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            CheckForWinner();
        }
        private void CheckForWinner()
        {
            // horizontal checks
            bool ThereIsAWinner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                ThereIsAWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                ThereIsAWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                ThereIsAWinner = true;
            }

            // vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                ThereIsAWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                ThereIsAWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                ThereIsAWinner = true;
            }

            // diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                ThereIsAWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                ThereIsAWinner = true;
            }


            if (ThereIsAWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = "O";
                    O_Wins = O_Wins + 1;
                    OScore.Text = O_Wins.ToString();
                }

                else
                {
                    winner = "X";
                    MessageBox.Show(winner + " Wins!", "Winner", MessageBoxButtons.OK);
                    X_Wins = X_Wins + 1;
                    XScore.Text = X_Wins.ToString();
                }

            }        // end if 

            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!", "Draw", MessageBoxButtons.OK);
                    Draw = Draw + 1;
                    DrawScore.Text = Draw.ToString();
                }
            }

        } // end checks for winner
        private void disableButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                } // end foreach
            }
            // end try
            catch { }

           
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                } // end foreach
            } // end try
            catch { }
        }
    }
}
