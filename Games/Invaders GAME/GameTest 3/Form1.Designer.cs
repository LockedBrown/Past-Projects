namespace GameTest_3
{
    partial class SpaceInvaders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceInvaders));
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.bulletMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.MeteorCountTimer = new System.Windows.Forms.Timer(this.components);
            this.MeteorMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlLose = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.pnlPaused = new System.Windows.Forms.Panel();
            this.lblRestart = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gamefinish = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.restartTimer = new System.Windows.Forms.Timer(this.components);
            this.GameVariablesTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCannotAfford = new System.Windows.Forms.Label();
            this.lblLessDelayBullets = new System.Windows.Forms.Label();
            this.lblFasterBullets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBulletTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.pnlPaused.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 1;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // bulletMovementTimer
            // 
            this.bulletMovementTimer.Enabled = true;
            this.bulletMovementTimer.Interval = 1;
            this.bulletMovementTimer.Tick += new System.EventHandler(this.bulletMovementTimer_Tick);
            // 
            // MeteorCountTimer
            // 
            this.MeteorCountTimer.Enabled = true;
            this.MeteorCountTimer.Interval = 200;
            this.MeteorCountTimer.Tick += new System.EventHandler(this.MeteorCountTimer_Tick);
            // 
            // MeteorMovementTimer
            // 
            this.MeteorMovementTimer.Interval = 200;
            this.MeteorMovementTimer.Tick += new System.EventHandler(this.MeteorMovementTimer_Tick);
            // 
            // pnlLose
            // 
            this.pnlLose.BackColor = System.Drawing.Color.Transparent;
            this.pnlLose.BackgroundImage = global::GameTest_3.Properties.Resources.earth_background;
            this.pnlLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLose.Location = new System.Drawing.Point(0, 3);
            this.pnlLose.Name = "pnlLose";
            this.pnlLose.Size = new System.Drawing.Size(165, 503);
            this.pnlLose.TabIndex = 1;
            // 
            // player
            // 
            this.player.Image = global::GameTest_3.Properties.Resources.Rocket_DOWN;
            this.player.Location = new System.Drawing.Point(170, 10);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pnlPaused
            // 
            this.pnlPaused.BackColor = System.Drawing.Color.DimGray;
            this.pnlPaused.Controls.Add(this.lblRestart);
            this.pnlPaused.Controls.Add(this.lblQuit);
            this.pnlPaused.Controls.Add(this.label1);
            this.pnlPaused.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaused.Location = new System.Drawing.Point(0, 0);
            this.pnlPaused.Name = "pnlPaused";
            this.pnlPaused.Size = new System.Drawing.Size(982, 89);
            this.pnlPaused.TabIndex = 2;
            this.pnlPaused.Visible = false;
            // 
            // lblRestart
            // 
            this.lblRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRestart.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(696, 0);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(143, 89);
            this.lblRestart.TabIndex = 2;
            this.lblRestart.Text = "Restart";
            this.lblRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit.ForeColor = System.Drawing.Color.Black;
            this.lblQuit.Location = new System.Drawing.Point(839, 0);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(143, 89);
            this.lblQuit.TabIndex = 1;
            this.lblQuit.Text = "Quit";
            this.lblQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Paused";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gamefinish
            // 
            this.Gamefinish.Enabled = true;
            this.Gamefinish.Interval = 1;
            this.Gamefinish.Tick += new System.EventHandler(this.Gamefinish_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblMoney);
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 80);
            this.panel1.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(654, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(327, 80);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney
            // 
            this.lblMoney.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(327, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(327, 80);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Money:";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRound
            // 
            this.lblRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblRound.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(0, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(327, 80);
            this.lblRound.TabIndex = 0;
            this.lblRound.Text = "Round: ";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartTimer
            // 
            this.restartTimer.Enabled = true;
            this.restartTimer.Interval = 1;
            // 
            // GameVariablesTimer
            // 
            this.GameVariablesTimer.Enabled = true;
            this.GameVariablesTimer.Interval = 1;
            this.GameVariablesTimer.Tick += new System.EventHandler(this.GameVariablesTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.lblCannotAfford);
            this.panel2.Controls.Add(this.lblLessDelayBullets);
            this.panel2.Controls.Add(this.lblFasterBullets);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 80);
            this.panel2.TabIndex = 4;
            // 
            // lblCannotAfford
            // 
            this.lblCannotAfford.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCannotAfford.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCannotAfford.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCannotAfford.Location = new System.Drawing.Point(433, 0);
            this.lblCannotAfford.Name = "lblCannotAfford";
            this.lblCannotAfford.Size = new System.Drawing.Size(549, 80);
            this.lblCannotAfford.TabIndex = 3;
            this.lblCannotAfford.Text = "Insufficient Funds";
            this.lblCannotAfford.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCannotAfford.Visible = false;
            // 
            // lblLessDelayBullets
            // 
            this.lblLessDelayBullets.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLessDelayBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessDelayBullets.ForeColor = System.Drawing.Color.White;
            this.lblLessDelayBullets.Location = new System.Drawing.Point(268, 0);
            this.lblLessDelayBullets.Name = "lblLessDelayBullets";
            this.lblLessDelayBullets.Size = new System.Drawing.Size(165, 80);
            this.lblLessDelayBullets.TabIndex = 2;
            this.lblLessDelayBullets.Text = "Less Bullet Delay: 300";
            this.lblLessDelayBullets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLessDelayBullets.Click += new System.EventHandler(this.lblLessDelayBullets_Click);
            // 
            // lblFasterBullets
            // 
            this.lblFasterBullets.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFasterBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFasterBullets.ForeColor = System.Drawing.Color.White;
            this.lblFasterBullets.Location = new System.Drawing.Point(134, 0);
            this.lblFasterBullets.Name = "lblFasterBullets";
            this.lblFasterBullets.Size = new System.Drawing.Size(134, 80);
            this.lblFasterBullets.TabIndex = 1;
            this.lblFasterBullets.Text = "Faster Bullets: 300";
            this.lblFasterBullets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFasterBullets.Click += new System.EventHandler(this.lblFasterBullets_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "Upgrades: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBulletTimer
            // 
            this.addBulletTimer.Enabled = true;
            this.addBulletTimer.Interval = 1;
            this.addBulletTimer.Tick += new System.EventHandler(this.addBulletTimer_Tick);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 400;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // SpaceInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPaused);
            this.Controls.Add(this.pnlLose);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpaceInvaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "METEOR";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaders_Down);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.pnlPaused.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Timer bulletMovementTimer;
        private System.Windows.Forms.Timer MeteorCountTimer;
        private System.Windows.Forms.Timer MeteorMovementTimer;
        private System.Windows.Forms.Panel pnlLose;
        private System.Windows.Forms.Panel pnlPaused;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Gamefinish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Timer restartTimer;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameVariablesTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLessDelayBullets;
        private System.Windows.Forms.Label lblFasterBullets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCannotAfford;
        private System.Windows.Forms.Timer addBulletTimer;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

