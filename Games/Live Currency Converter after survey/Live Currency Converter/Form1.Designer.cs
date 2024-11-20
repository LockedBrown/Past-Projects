namespace Live_Currency_Converter
{
    partial class Form1
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
            this.btnGBPtoC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHomeTwo = new System.Windows.Forms.Button();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnHomeOne = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.boxGBPtoC = new System.Windows.Forms.ComboBox();
            this.txtGBPtoC = new System.Windows.Forms.TextBox();
            this.txtCtoGBP = new System.Windows.Forms.TextBox();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.lblHeadingTwo = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeadingOne = new System.Windows.Forms.Label();
            this.lblHeadingThree = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCtoGBP = new System.Windows.Forms.Button();
            this.boxCtoGBP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGBPtoC
            // 
            this.btnGBPtoC.BackColor = System.Drawing.Color.White;
            this.btnGBPtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGBPtoC.Location = new System.Drawing.Point(222, 268);
            this.btnGBPtoC.Margin = new System.Windows.Forms.Padding(2);
            this.btnGBPtoC.Name = "btnGBPtoC";
            this.btnGBPtoC.Size = new System.Drawing.Size(74, 26);
            this.btnGBPtoC.TabIndex = 0;
            this.btnGBPtoC.Text = "Start";
            this.btnGBPtoC.UseVisualStyleBackColor = false;
            this.btnGBPtoC.Click += new System.EventHandler(this.btnGBPtoC_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(112)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.btnHomeTwo);
            this.panel1.Controls.Add(this.pnlBtn);
            this.panel1.Controls.Add(this.btnHomeOne);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 317);
            this.panel1.TabIndex = 1;
            // 
            // btnHomeTwo
            // 
            this.btnHomeTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(112)))), ((int)(((byte)(201)))));
            this.btnHomeTwo.FlatAppearance.BorderSize = 0;
            this.btnHomeTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTwo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnHomeTwo.Location = new System.Drawing.Point(15, 71);
            this.btnHomeTwo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeTwo.Name = "btnHomeTwo";
            this.btnHomeTwo.Size = new System.Drawing.Size(84, 50);
            this.btnHomeTwo.TabIndex = 17;
            this.btnHomeTwo.Text = "Currency To GBP";
            this.btnHomeTwo.UseVisualStyleBackColor = false;
            this.btnHomeTwo.Click += new System.EventHandler(this.btnHomeTwo_Click);
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlBtn.Location = new System.Drawing.Point(3, 10);
            this.pnlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(10, 50);
            this.pnlBtn.TabIndex = 16;
            // 
            // btnHomeOne
            // 
            this.btnHomeOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(112)))), ((int)(((byte)(201)))));
            this.btnHomeOne.FlatAppearance.BorderSize = 0;
            this.btnHomeOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeOne.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnHomeOne.Location = new System.Drawing.Point(15, 10);
            this.btnHomeOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeOne.Name = "btnHomeOne";
            this.btnHomeOne.Size = new System.Drawing.Size(84, 50);
            this.btnHomeOne.TabIndex = 4;
            this.btnHomeOne.Text = "GBP To  Currency";
            this.btnHomeOne.UseVisualStyleBackColor = false;
            this.btnHomeOne.Click += new System.EventHandler(this.btnHomeOne_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.btnRestart.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnRestart.Location = new System.Drawing.Point(8, 254);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(82, 25);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnExit.Location = new System.Drawing.Point(8, 284);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // boxGBPtoC
            // 
            this.boxGBPtoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxGBPtoC.FormattingEnabled = true;
            this.boxGBPtoC.Items.AddRange(new object[] {
            "- Select Currency - ",
            "Euro",
            "United States Dollars",
            "Danish Krones",
            "Chinese Yuan",
            "Canadian Dollar",
            "Swiss Franc",
            "New Zealand Dollar"});
            this.boxGBPtoC.Location = new System.Drawing.Point(287, 154);
            this.boxGBPtoC.Margin = new System.Windows.Forms.Padding(2);
            this.boxGBPtoC.Name = "boxGBPtoC";
            this.boxGBPtoC.Size = new System.Drawing.Size(125, 21);
            this.boxGBPtoC.TabIndex = 3;
            this.boxGBPtoC.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            // 
            // txtGBPtoC
            // 
            this.txtGBPtoC.Location = new System.Drawing.Point(133, 154);
            this.txtGBPtoC.Margin = new System.Windows.Forms.Padding(2);
            this.txtGBPtoC.Name = "txtGBPtoC";
            this.txtGBPtoC.Size = new System.Drawing.Size(92, 20);
            this.txtGBPtoC.TabIndex = 4;
            this.txtGBPtoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitPress);
            // 
            // txtCtoGBP
            // 
            this.txtCtoGBP.Location = new System.Drawing.Point(133, 154);
            this.txtCtoGBP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCtoGBP.Name = "txtCtoGBP";
            this.txtCtoGBP.Size = new System.Drawing.Size(92, 20);
            this.txtCtoGBP.TabIndex = 5;
            this.txtCtoGBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitPress);
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(213, 221);
            this.txtExchange.Margin = new System.Windows.Forms.Padding(2);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(92, 20);
            this.txtExchange.TabIndex = 6;
            this.txtExchange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitPress);
            // 
            // lblHeadingTwo
            // 
            this.lblHeadingTwo.AutoSize = true;
            this.lblHeadingTwo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblHeadingTwo.ForeColor = System.Drawing.Color.Black;
            this.lblHeadingTwo.Location = new System.Drawing.Point(227, 102);
            this.lblHeadingTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeadingTwo.Name = "lblHeadingTwo";
            this.lblHeadingTwo.Size = new System.Drawing.Size(66, 18);
            this.lblHeadingTwo.TabIndex = 7;
            this.lblHeadingTwo.Text = ">   To   >";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 22F);
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(141, 13);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(254, 35);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "GBP To Converter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(204, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exchange Rates";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(112)))), ((int)(((byte)(201)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(447, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 317);
            this.panel2.TabIndex = 11;
            // 
            // lblHeadingOne
            // 
            this.lblHeadingOne.AutoSize = true;
            this.lblHeadingOne.Font = new System.Drawing.Font("Arial", 12F);
            this.lblHeadingOne.Location = new System.Drawing.Point(158, 100);
            this.lblHeadingOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeadingOne.Name = "lblHeadingOne";
            this.lblHeadingOne.Size = new System.Drawing.Size(42, 18);
            this.lblHeadingOne.TabIndex = 12;
            this.lblHeadingOne.Text = "GBP";
            // 
            // lblHeadingThree
            // 
            this.lblHeadingThree.AutoSize = true;
            this.lblHeadingThree.Font = new System.Drawing.Font("Arial", 12F);
            this.lblHeadingThree.Location = new System.Drawing.Point(310, 100);
            this.lblHeadingThree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeadingThree.Name = "lblHeadingThree";
            this.lblHeadingThree.Size = new System.Drawing.Size(70, 18);
            this.lblHeadingThree.TabIndex = 13;
            this.lblHeadingThree.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label6.Location = new System.Drawing.Point(140, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter Amount..";
            // 
            // btnCtoGBP
            // 
            this.btnCtoGBP.BackColor = System.Drawing.Color.White;
            this.btnCtoGBP.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnCtoGBP.Location = new System.Drawing.Point(222, 268);
            this.btnCtoGBP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCtoGBP.Name = "btnCtoGBP";
            this.btnCtoGBP.Size = new System.Drawing.Size(74, 26);
            this.btnCtoGBP.TabIndex = 17;
            this.btnCtoGBP.Text = "Start";
            this.btnCtoGBP.UseVisualStyleBackColor = false;
            this.btnCtoGBP.Click += new System.EventHandler(this.btnCtoGBP_Click);
            // 
            // boxCtoGBP
            // 
            this.boxCtoGBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCtoGBP.FormattingEnabled = true;
            this.boxCtoGBP.Items.AddRange(new object[] {
            "- Select Currency - ",
            "Euro",
            "United States Dollars",
            "Danish Krones",
            "Chinese Yuan",
            "Canadian Dollar",
            "Swiss Franc",
            "New Zealand Dollar"});
            this.boxCtoGBP.Location = new System.Drawing.Point(287, 154);
            this.boxCtoGBP.Margin = new System.Windows.Forms.Padding(2);
            this.boxCtoGBP.Name = "boxCtoGBP";
            this.boxCtoGBP.Size = new System.Drawing.Size(125, 21);
            this.boxCtoGBP.TabIndex = 20;
            this.boxCtoGBP.DropDownClosed += new System.EventHandler(this.CurrencytoGBP);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label8.Location = new System.Drawing.Point(305, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Select Currency..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(359, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(371, 268);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(455, 317);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxCtoGBP);
            this.Controls.Add(this.btnCtoGBP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHeadingThree);
            this.Controls.Add(this.lblHeadingOne);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblHeadingTwo);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.txtCtoGBP);
            this.Controls.Add(this.txtGBPtoC);
            this.Controls.Add(this.boxGBPtoC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGBPtoC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGBPtoC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox boxGBPtoC;
        private System.Windows.Forms.TextBox txtGBPtoC;
        private System.Windows.Forms.TextBox txtCtoGBP;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label lblHeadingTwo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeadingOne;
        private System.Windows.Forms.Label lblHeadingThree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHomeOne;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnCtoGBP;
        private System.Windows.Forms.ComboBox boxCtoGBP;
        private System.Windows.Forms.Button btnHomeTwo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

