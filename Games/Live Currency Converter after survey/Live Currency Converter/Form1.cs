using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideCtoGBP();
            boxGBPtoC.SelectedIndex = 0;
            boxCtoGBP.SelectedIndex = 0;
        }

        float amount = 0, exchangeRate = 0, result = 0;
        // Closes program
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hides Currency Boxes
        void HideCtoGBP()
        {
            // Hides Currency to GBP entitys
            btnCtoGBP.Hide();
            boxCtoGBP.Hide();
            txtCtoGBP.Hide();

            // Changes the heading
            lblHeading.Text = "GBP To Currency";
            lblHeadingOne.Text = "GBP";
            lblHeadingTwo.Text = ">  To  >";
            lblHeadingThree.Text = "Currency";

            // Shows GBP to Currency entitys
            btnGBPtoC.Show();
            boxGBPtoC.Show();
            txtGBPtoC.Show();
        }

        // Hides GBP boxes
        void HideGBPtoC()
        {
            // Hides Currency to GBP entitys
            btnCtoGBP.Show();
            boxCtoGBP.Show();
            txtCtoGBP.Show();

            // Changes the heading
            lblHeading.Text = "Currency To GBP";
            lblHeadingOne.Text = "GBP";
            lblHeadingTwo.Text = "<  To  <";
            lblHeadingThree.Text = "Currency";

            // Shows GBP to Currency entitys
            btnGBPtoC.Hide();
            boxGBPtoC.Hide();
            txtGBPtoC.Hide();
        }

        //GBP To currency - Sets Exchange rate on drop down leave
        private void DropDownClosed(object sender, EventArgs e)
        {
         
            if (boxGBPtoC.SelectedIndex == 0)
            {
                txtExchange.Text = "";
            }
            if (boxGBPtoC.SelectedIndex == 1)
            {
                txtExchange.Text = "1.17";
            }
            if (boxGBPtoC.SelectedIndex == 2)
            {
                txtExchange.Text = "1.32";
            }
            if (boxGBPtoC.SelectedIndex == 3)
            {
                txtExchange.Text = "8.70";
            }
            if (boxGBPtoC.SelectedIndex == 4)
            {
                txtExchange.Text = "8.85";
            }
            if (boxGBPtoC.SelectedIndex == 5)
            {
                txtExchange.Text = "1.77";
            }
            if (boxGBPtoC.SelectedIndex == 6)
            {
                txtExchange.Text = "1.31";
            }
            if (boxGBPtoC.SelectedIndex == 7)
            {
                txtExchange.Text = "1.91";
            }
        }

        // Changes to GBP to Currency
        private void btnHomeOne_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = btnHomeOne.Top;
            pnlBtn.Height = btnHomeOne.Height;


            HideCtoGBP();

           
        }

        // Restarts program
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Resetting Values
            txtGBPtoC.Text = "";
            txtExchange.Text = "";
            txtCtoGBP.Text = "";
            lblResult.Text = "";

            boxGBPtoC.SelectedIndex = 0;
            boxCtoGBP.SelectedIndex = 0;

            // Sets converter to GBP to Currency
            HideCtoGBP();
            pnlBtn.Top = btnHomeOne.Top;
            pnlBtn.Height = btnHomeOne.Height;
        }

        // CURRENCY TO GBP BUTTON
        private void btnCtoGBP_Click(object sender, EventArgs e)
        {
             
            if (boxGBPtoC.SelectedIndex != 0)
            {
                MessageBox.Show("Please choose one currency at a time", "Validation", MessageBoxButtons.OK);
                return;
            }

            // If Exchange Rate is Empty
            if (txtExchange.Text == "")
            {
                MessageBox.Show("Please choose a Currency from the list or enter an amount into the exchange rate", "Validation", MessageBoxButtons.OK);
                return;
            }
            // If Amount Box is Empty
            if (txtCtoGBP.Text == "")
            {
                MessageBox.Show("Please enter an amount into the amount textbox", "Validation", MessageBoxButtons.OK);
                return;
            }

            
            amount = float.Parse(txtCtoGBP.Text);
            exchangeRate = float.Parse(txtExchange.Text);

            // If amount isn't positive
            if (amount < 0)
            {
                MessageBox.Show("Please enter a positive amount", "Validation", MessageBoxButtons.OK);
            }
            // If Exchange rate isn't positive
            if (exchangeRate < 0)
            {
                MessageBox.Show("Please enter a positive exchange rate", "Validation", MessageBoxButtons.OK);
            }
            result = amount * exchangeRate;
            MessageBox.Show("Currency to GBP is " + result).ToString();
            lblResult.Text = result.ToString();
        }

        // Changes to Currency to GBP
        private void btnHomeTwo_Click(object sender, EventArgs e)
        {

            //Resetting Values
            txtGBPtoC.Text = "";
            txtExchange.Text = "";
            txtCtoGBP.Text = "";
            lblResult.Text = "";

            boxGBPtoC.SelectedIndex = 0;
            boxCtoGBP.SelectedIndex = 0;

            pnlBtn.Top = btnHomeTwo.Top;
            pnlBtn.Height = btnHomeTwo.Height;

            HideGBPtoC();
        }

        private void DigitPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        // GBP To CURRENCY BUTTON
        private void btnGBPtoC_Click(object sender, EventArgs e)
        {
            if(boxCtoGBP.SelectedIndex != 0)
            {
                MessageBox.Show("Please choose one currency at a time", "Validation", MessageBoxButtons.OK);
                return;
            }

            if(txtExchange.Text == "")
            {
                MessageBox.Show("Please choose a Currency from the list or enter an amount into the exchange rate", "Validation", MessageBoxButtons.OK);
                return;
            }

            if(txtGBPtoC.Text == "")
            {
                MessageBox.Show("Please enter an amount into the amount textbox", "Validation", MessageBoxButtons.OK);
                return;
            }

            if (amount < 0)
            {
                MessageBox.Show("Please enter a positive amount", "Validation", MessageBoxButtons.OK);
            }
            if (exchangeRate < 0)
            {
                MessageBox.Show("Please enter a positive exchange rate", "Validation", MessageBoxButtons.OK);
            }

            amount = float.Parse(txtGBPtoC.Text);
            exchangeRate = float.Parse(txtExchange.Text);
            result = amount * exchangeRate;
            MessageBox.Show("GBP To this currency is " + result).ToString();
            lblResult.Text = result.ToString();
        }

        private void CurrencytoGBP(object sender, EventArgs e)
        {
            // Currency To GBP
            if (boxCtoGBP.SelectedIndex == 0)
            {
                txtExchange.Text = "";
            }
            if (boxCtoGBP.SelectedIndex == 1)
            {
                txtExchange.Text = "0.86";
            }
            if (boxCtoGBP.SelectedIndex == 2)
            {
                txtExchange.Text = "0.76";
            }
            if (boxCtoGBP.SelectedIndex == 3)
            {
                txtExchange.Text = "0.11";
            }
            if (boxCtoGBP.SelectedIndex == 4)
            {
                txtExchange.Text = "0.11";
            }
            if (boxCtoGBP.SelectedIndex == 5)
            {
                txtExchange.Text = "0.56";
            }
            if (boxCtoGBP.SelectedIndex == 6)
            {
                txtExchange.Text = "0.76";
            }
            if (boxCtoGBP.SelectedIndex == 7)
            {
                txtExchange.Text = "0.52";
            }
        }
    }
}
