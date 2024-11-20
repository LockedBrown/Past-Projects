using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest_3
{
    public partial class SpaceInvaders : Form
    {
        public SpaceInvaders()
        {
            InitializeComponent();
            StartPlayer();
            pnlPaused.BackColor = Color.DimGray;
            label1.Text = "Game Paused";
            pnlPaused.Visible = false;
            RoundCount = 1;
            RoundsSettings();
            lblMoney.Text = "Money: " + Money;
            lblScore.Text = "Score: " + Score;
            ClockTimer.Interval = 400;
        }

        //-------------------------------------------------------- Data Declaration --------------------------

        //Control bools
        bool Down = true, Up = false, shoot = false;
        // Paused / Game Over 
        bool Paused = false, gameover = false;
        // Counts to 300 to allow the player to shoot
        bool BulletClock = false;
        int BulletSpeed = 9;
        // Tick Inteval Variable
        int TickInterval = 20;
        // Animation index so animations play
        int index = 0;
        
        // Game Variables
        int Money = 150;
        int Score = 0;
        int fasterBulletCost = 300;
        int lessDelayCost = 300;
        // Round Variables
        int RoundCount = 1;

        // Meteor variables
        List<Meteor> MeteorList = new List<Meteor>();
        int MeteorCount = 0;
        int HowMany = 0;
        int speedOne = 0, speedTwo = 0;

        // Bullet variables
        List<bullet> BulletList = new List<bullet>();

        //-------------------------------------------------------- Key Down ----------------------------------

        // If the key is being held
        private void SpaceInvaders_Down(object sender, KeyEventArgs e)
        {
            // Key W / Up Arrow - GO UP
            if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
            {
                Up = true;
                Down = false;
                Paused = false;
            }

            // Key S / Down Arrow - GO DOWN
            if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
            {
                Down = true;
                Up = false;
                Paused = false;

            }

            // Key Esc - PAUSE GAME
            if (e.KeyData == Keys.Escape)
            {
                Down = false;
                Up = false;
                Paused = true;
            }

            if (e.KeyData == Keys.Space)
            {
                shoot = true;
            }


            




        }


        //-------------------------------------------------------- Click Events ------------------------------

        // Exits program
        private void lblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Resets the variables when restarted
        private void lblRestart_Click(object sender, EventArgs e)
        {
            // Disables Timers to carry out next steps
            movementTimer.Enabled = false;
            MeteorCountTimer.Enabled = false;
            bulletMovementTimer.Enabled = false;
            Gamefinish.Enabled = false;

            // Removes Meteors & images
            MeteorList.RemoveAll(Meteor => Meteor.isDisposed);
            foreach (Meteor meteor in MeteorList)
            {
                meteor.isDisposed = true;
                meteor.aMeteor.Dispose();

            }

            // Initializing Start
            Money = 150;
            Score = 0;
            fasterBulletCost = 300;
            lessDelayCost = 300;
            BulletSpeed = 9;
            StartPlayer();
            pnlPaused.BackColor = Color.DimGray;
            label1.Text = "Game Paused";
            lblMoney.Text = "Money: " + Money;
            lblScore.Text = "Score: " + Score;
            lblFasterBullets.Text = "Faster Bullets: " + fasterBulletCost;
            lblLessDelayBullets.Text = "Less Bullet Delay: " + lessDelayCost;
            pnlPaused.Visible = false;
            MeteorCount = 0;
            RoundCount = 1;
            RoundsSettings();
            ClockTimer.Interval = 400;
            lblCannotAfford.Visible = false;

            // Tick Inteval Variable
            TickInterval = 20;

            // Resetting Variables
            Up = false;
            Down = true;
            index = 0;
            BulletClock = false;
            gameover = false;
            Paused = false;

            // Re-enables timers
            movementTimer.Enabled = true;
            MeteorCountTimer.Enabled = true;
            bulletMovementTimer.Enabled = true;
            Gamefinish.Enabled = true;
            MeteorMovementTimer.Enabled = false;

        }
        // Faster Bullets Upgrade button
        private void lblFasterBullets_Click(object sender, EventArgs e)
        {
            lblCannotAfford.Visible = false;
            
            if(Money >= fasterBulletCost)
            {
                // Takes away cost
                Money -= fasterBulletCost;
                // Adds more to cost
                fasterBulletCost += 300;
                // Changes costs text
                lblFasterBullets.Text = "Faster Bullets: " + fasterBulletCost;
                // tells user they purchased
                lblCannotAfford.Text = "Purchased";
                lblCannotAfford.Visible = true;
                lblCannotAfford.ForeColor = Color.FromArgb(128, 255, 128);

                // changes bullet speed
                BulletSpeed += 3; 
                                   
            }
            else
            {
                // tells user they cannot afford
                lblCannotAfford.Text = "Insufficient Funds";
                lblCannotAfford.ForeColor = Color.FromArgb(255, 128, 128);
                lblCannotAfford.Visible = true;
            }
        }
        // Less bullet Delay Upgrade button
        private void lblLessDelayBullets_Click(object sender, EventArgs e)
        {
            lblCannotAfford.Visible = false;

            if(Money >= lessDelayCost)
            {
                // Takes away cost
                Money -= lessDelayCost;
                // Adds more to cost
                lessDelayCost += 300;
                // Changes costs text
                lblLessDelayBullets.Text = "Less Bullet Delay: " + lessDelayCost;
                // tells user they have purchased
                lblCannotAfford.Text = "Purchased";
                lblCannotAfford.Visible = true;
                lblCannotAfford.ForeColor = Color.FromArgb(128, 255, 128);

                ClockTimer.Interval -= TickInterval;
            }
            else
            {
                // tells user they cannot afford
                lblCannotAfford.Text = "Insufficient Funds";
                lblCannotAfford.ForeColor = Color.FromArgb(255, 128, 128);
                lblCannotAfford.Visible = true;
            }
        }


        //-------------------------------------------------------- Game Setting Functions ---------------------

        // Sets the players X/Y Position
        void StartPlayer()
        {
            // Player start pos
            player.Top = 50;
            player.Left = 170;
            player.Image = Properties.Resources.Rocket_DOWN;
            player.Width = 50;
            player.Height = 50;
            player.SizeMode = PictureBoxSizeMode.Zoom;
        }
        // This sets the rounds variables
        void RoundsSettings()
        {   // Round One Settings

            if (RoundCount == 1)
            {
                lblRound.Text = "Round: " + RoundCount;
                // How Many Meteors
                HowMany = 5;
                // Used for random argument 1
                speedOne = 5;
                // Used for random argument 2
                speedTwo = 10;
                MeteorCountTimer.Enabled = true;
            }
            else if (RoundCount == 2)
            {
                lblRound.Text = "Round: " + RoundCount;
                HowMany = 7;
                speedOne = 7;
                speedTwo = 12;
                MeteorCountTimer.Enabled = true;
            }
            else if (RoundCount == 3)
            {
                lblRound.Text = "Round: " + RoundCount;
                HowMany = 10;
                speedOne = 10;
                speedTwo = 15;
                MeteorCountTimer.Enabled = true;
            }
            else if (RoundCount >= 4)
            {
                lblRound.Text = "Round: " + RoundCount;
                HowMany +=1;
                speedOne +=1;
                speedTwo += 1;
                MeteorCountTimer.Enabled = true;
            }

        }
        // This is the settings if the user has won
        void GameWin()
        {
            pnlPaused.Visible = true;
            pnlPaused.BackColor = Color.Green;
            label1.Text = "You win";

            MeteorMovementTimer.Enabled = false;
            movementTimer.Enabled = false;
            MeteorCountTimer.Enabled = false;
            bulletMovementTimer.Enabled = false;

        }


        //-------------------------------------------------------- Timers -------------------------------------

        // Checking if movement bools are true
        private void movementTimer_Tick(object sender, EventArgs e)
        {
            index++;
            // Allows the animations to play
            if (Up == true && index % 30 == 0)
            {
                player.Image = Properties.Resources.Rocket_UP;
            }
            if (Down == true && index % 30 == 0)
            {
                player.Image = Properties.Resources.Rocket_DOWN;
            }
            // if the user presses W go up, if the player reaches the roof, reset position to bottom.
            if (Up)
            {
                if (player.Top + player.Height - 5 <= 0)
                {
                    player.Top = 435;
                }
                else
                {
                    player.Top -= 3;
                }
            }
            // If the user presses S go down, if the player reaches the bottom reset position to the top.
            if (Down)
            {
                if (player.Top + player.Height - 5 >= 450)
                {
                    player.Top = -35;
                }
                else
                {
                    player.Top += 3;
                }
            }
            // If the user has pressed Esc / pause the game
            if (Paused)
            {
                Down = false;
                Up = false;
                pnlPaused.Visible = true;


            }
            // If the game isn't paused
            else
            {
                pnlPaused.Visible = false;

            }



        }
        // Timer that sets the score / money labels
        private void GameVariablesTimer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + Score;
            lblMoney.Text = "Money: " + Money;
        }
        // Adds a bullet if shoot & clock = true
        private void addBulletTimer_Tick(object sender, EventArgs e)
        {
            if (shoot && BulletClock == true)
            {
                BulletList.Add(new bullet(this, player));
                shoot = false;
                BulletClock = false;
            }

        }
        // This times the bullet to shoot / sets clock = true
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            BulletClock = true;
        }
        // Bullet movement
        private void bulletMovementTimer_Tick(object sender, EventArgs e)
        {
            // If Disposed = True, bullet removed from list
            BulletList.RemoveAll(bullet => bullet.isDisposed);

            // Do this for one bullet and repeat
            foreach (bullet bullet in BulletList)
            {
                //Bullet Movement
                bullet.moveBullet(this, Paused, BulletSpeed);

                // Do this for one meteor and repeat
                foreach (Meteor aMeteor in MeteorList)
                {
                    if (bullet.abullet.Bounds.IntersectsWith(aMeteor.aMeteor.Bounds))
                    {
                        Money += aMeteor.CashGiven();
                        Score += aMeteor.ScoreGiven();
                        // If bullet touches Meteor then dispose of them both.
                        bullet.isDisposed = true;
                        bullet.abullet.Dispose();
                        aMeteor.isDisposed = true;
                        aMeteor.aMeteor.Dispose();


                    }
                }

            }



        }
        // If Gameover = true, game finishes
        private void Gamefinish_Tick(object sender, EventArgs e)
        {
            if (gameover)
            {
                MeteorMovementTimer.Enabled = false;
                movementTimer.Enabled = false;
                MeteorCountTimer.Enabled = false;
                bulletMovementTimer.Enabled = false;

                pnlPaused.Visible = true;
                pnlPaused.BackColor = Color.Red;
                label1.Text = "Game Over";
            }
        }
        // Meteor movement / Game Over if Meteor touches panel
        private void MeteorMovementTimer_Tick(object sender, EventArgs e)
        {
            // If Meteor Disposed = true then remove meteor from list
            MeteorList.RemoveAll(Meteor => Meteor.isDisposed);

            foreach (Meteor aMeteor in MeteorList)
            {
                // MOve Meteor
                aMeteor.MoveMeteor(this, Paused);

                // If Meteor touches panel then game over
                if (pnlLose.Bounds.IntersectsWith(aMeteor.aMeteor.Bounds))
                {
                    // Stops the game
                    MeteorMovementTimer.Enabled = false;
                    gameover = true;

                    return;
                }

            }
            if (MeteorList.Count == 0)
            {
                MeteorCount = 0;
                RoundCount += 1;
                RoundsSettings();


            }


        }
        // Adding Meteors
        private void MeteorCountTimer_Tick(object sender, EventArgs e)
        {

            // Meteor Amount if HowMany then disable adding meteor - HowMany Is set on what round
            if (MeteorCount >= HowMany)
            {
                // Enables the movement timer
                MeteorMovementTimer.Enabled = true;

                // Disables this timer - re enabled when enemys are gone
                MeteorCountTimer.Enabled = false;

            }
            else
            {
                // If not HowMany Value, then add more meteors
                MeteorList.Add(new Meteor(this, speedOne, speedTwo));
                MeteorCount++;
            }
        }





    }
}
