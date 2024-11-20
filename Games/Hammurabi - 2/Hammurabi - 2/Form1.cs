using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammurabi___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblEnd1.Hide();
            lblEnd2.Hide();
        }

        // Data declaration
        int Year = 1;
        int PeopleToCity = 0;
        int Population = 100;
        int Trading = 16;
        int Harvest = 0;
        int Rats = 200;
        int BushelStorage = 2800;
        int Bushels = 2800;
        int Acres = 1000;
        int AcresStorage = 1000;
        int PeopleStarved = 0;
        int PeopleStarvedCount = 0;

        // Plague
        int PlagueRandomChance = 0;

        // TextBox Inputs
        int BuyOrSellInput = 0;
        int PlantedInput = 0;
        int FeedInput = 0;

        // Randoms
        int RandomTrading = 0;
        int RandomPeopleCity = 0;
        int RandomRats = 0;
        int RandomHarvest = 0;

        // Input Calculations
        int PopulationCalculation = 0;

        // End game calculations
        double AcresPerPerson = 0;
        double PeopleStarvedAverage = 0;




        Random random = new Random();



        private void btnNext_Click(object sender, EventArgs e)
        {
            // Calling Voids
        
            EndTurn();
            YearFunction();
           


        }

        private void EndTurn()
        {
            AcresStorage = Acres;

            if (txtBuySell.Text.Length >= 1)
            {
                if (txtFeed.Text.Length == 0 || txtPlant.Text.Length == 0)
                {
                    MessageBox.Show("Please Input an amount into the textboxes", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Acres <= 400)
                    {
                        EndScreen();
                        return;
                    }

                }

            }
                if (txtFeed.Text.Length >= 1) // if textbox has anything inputted
                {

                    // Determines how many died from starvation i.e. 1980(feed input) / 20 = 99, 99 - Population = 1 Starved
                    PopulationCalculation = FeedInput / 20;
                    PeopleStarved = (Population - PopulationCalculation);
                    PeopleStarvedCount = PeopleStarved + PeopleStarvedCount;
                    Population = Population - PeopleStarved;

                    if (PeopleStarved > 50)
                    {
                        EndScreen();
                        return;
                    }
                }
                else // Error message for No input in Feed textbox
                {
                    MessageBox.Show("Please input an amount to feed!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                if (txtPlant.Text.Length >= 1)
                {
                    PlantedInput = int.Parse(txtPlant.Text);

                    if (PlantedInput > Acres) // if input is more than acres
                    {
                        MessageBox.Show("Not enough acres!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else if (PlantedInput <= Acres) // If input is less than acres
                    {

                            // Adding random harvest
                            RandomHarvest = random.Next(2, 5);
                            Harvest = RandomHarvest;

                            Bushels = Bushels + (PlantedInput * Harvest);
                        
                    }



                }
                else // Error message if plant textbox is empty
                {
                    MessageBox.Show("You need to plant otherwise, you can't feed your people!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }




                // after all calculations calls voids
                RandomFunction();
                Plague();
                ResetingTextBoxes();


                // Sets the year
                Year = Year + 1;
                lblYear.Text = "Year: " + Year + ",";

                // Settings the labels text after calculations
                lblStarved.Text = PeopleStarved + " people starved.";
                lblAcresOwned.Text = "The city now owns " + Acres + " acres.";
                lblBushelsRemaining.Text = Bushels + " bushels remaining.";
                lblBushelsStore.Text = "You now have " + BushelStorage + " bushels in store.";
                lblTrading.Text = "Land is trading at " + Trading + " bushels per acre.";
                lblPeopleToCity.Text = PeopleToCity + " people came to the city.";
                lblRats.Text = "Rats ate " + Rats + " bushels.";
                lblHarvested.Text = "You harvested " + Harvest + " bushels per acre.";
                lblPopulation.Text = "The city population is now " + Population + ".";


        }
        

            private void RandomFunction()
            {
                // Adding random trading
                RandomTrading = random.Next(17, 26);
                Trading = RandomTrading;


                // Adding randoms to the city
                RandomPeopleCity = random.Next(1, 6);
                PeopleToCity = RandomPeopleCity;


                // If year at 5 then people to city goes from 1, 6 to 3, 12;
                if (Year >= 5)
                {
                    RandomPeopleCity = random.Next(3, 12);
                }

                // Adding Random rats
                RandomRats = random.Next(0, 200);
                Rats = RandomRats;
                Bushels = Bushels - Rats;
                BushelStorage = Bushels;


                // Adds population
                Population = Population + PeopleToCity;

            }
            private void EndScreen()
            {
                lblYear.Hide();
                lblTrading.Hide();
                lblStarved.Hide();
                lblRats.Hide();
                lblPopulation.Hide();
                lblPeopleToCity.Hide();
                lblHarvested.Hide();
                lblBushelsStore.Hide();
                lblAcresOwned.Hide();
                lblBushelsRemaining.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                txtBuySell.Hide();
                txtFeed.Hide();
                txtPlant.Hide();
                btnNext.Hide();




                // Changing labels to end screen text
                lblHarvested.Text = "You starved 100 people in one year!";
                lblRats.Text = "Due to this extreme mismanagement, you have not only been impeached and";
                lblBushelsStore.Text = "thrown out of office, but you have also been declared 'National Fink'!!";

                lblHarvested.Show();
                lblRats.Show();
                lblBushelsStore.Show();
                lblEnd1.Show();
                lblEnd2.Show();
            }
            private void YearFunction()
            {

                // If statement to hide gamescreen at year 11
                if (Year >= 11)
                {

                    if (Acres <= 700 && PeopleStarvedCount >= 10)
                    {
                        BadEnd();
                    }
                    else if (Acres <= 900 && PeopleStarvedCount >= 6)
                    {
                        GoodEnd();
                    }
                    else if (Acres >= 1000 && PeopleStarvedCount <= 5)
                    {
                        FantasticEnd();
                    }

                }
            }

            private void ResetingTextBoxes()
            {
                txtBuySell.Clear();
                txtFeed.Clear();
                txtPlant.Clear();
            }

            private void RestartFunction()
            {
                // Resets TextBoxes
                ResetingTextBoxes();

                // Reseting Variables
                BushelStorage = 2800;
                Bushels = 2800;

                Acres = 1000;
                BuyOrSellInput = 0;
                PlantedInput = 0;
                FeedInput = 0;
                RandomTrading = 0;
                RandomPeopleCity = 0;
                RandomRats = 0;
                RandomHarvest = 0;
                PeopleStarved = 0;
                PopulationCalculation = 0;
                PeopleStarvedCount = 0;
                AcresPerPerson = 0;
                PeopleStarvedAverage = 0;
                PlagueRandomChance = 0;
                AcresStorage = 1000;



                // Resetting the plague
                lblPlague.Text = "";

                // Reseting Starved
                lblStarved.Text = PeopleStarved + " people starved.";

                // Reseting Acres
                lblAcresOwned.Text = "The city now owns " + Acres + " acres.";

                // Reset Bushels
                lblBushelsStore.Text = "You now have " + Bushels + " bushels in store.";
                lblBushelsRemaining.Text = Bushels + " bushels remaining.";

                //This resets the year back to 1
                Year = 1;
                lblYear.Text = "Year: " + Year + ",";

                // Reseting the people to city label / variable
                PeopleToCity = 0;
                lblPeopleToCity.Text = PeopleToCity + " people came to the city.";

                // reseting the population label / variable
                Population = 100;
                lblPopulation.Text = "The city population is now " + Population + ".";

                // Reseting the trading back to normal
                Trading = 16;
                lblTrading.Text = "Land is trading at " + Trading + " bushels per acre.";

                // Resetting rats
                Rats = 200;
                lblRats.Text = "Rats ate " + Rats + " bushels.";

                // Resetting the harvest
                Harvest = 0;
                lblHarvested.Text = "You harvested " + Harvest + " bushels per acre.";

                // This is to reset ending screen
                lblYear.Show();
                lblTrading.Show();
                lblStarved.Show();
                lblRats.Show();
                lblPopulation.Show();
                lblPeopleToCity.Show();
                lblHarvested.Show();
                lblBushelsStore.Show();
                lblAcresOwned.Show();
                lblBushelsRemaining.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                label15.Show();
                txtBuySell.Show();
                txtFeed.Show();
                txtPlant.Show();
                btnNext.Show();

                lblEnd1.Hide();
                lblEnd2.Hide();
            }
            void TipPage()
        {
            hide();

            lblYear.Show();
            lblPopulation.Show();
            lblPeopleToCity.Show();
            lblAcresOwned.Show();

            lblYear.Text = "Tips:";
            lblStarved.Text = "";
            lblPeopleToCity.Text = "Tip 1: Start with trying to feed all, or most.";
            lblPopulation.Text = "Tip 2: Try plant on all acres.";
            lblHarvested.Text = "";
            lblAcresOwned.Text = "Tip 3: Last, if you have grain remaining, you might spend some buying additional acres of land, \n especially if the price is right. If you didn't have enough grain for food and seed,\n you may need to sell some of your land, hopefully, at a good price. ";
            lblRats.Text = "";
            lblBushelsStore.Text = "";
            lblTrading.Text = "";

        }

        private void btnRules_Click(object sender, EventArgs e)
            {
                // Changes the panel to follow button clicks
                panel2.Height = btnRules.Height;
                panel2.Top = btnRules.Top;
                RulePage();
            }

            private void btnTips_Click(object sender, EventArgs e)
            {
                // Changes the panel to follow button clicks
                panel2.Top = btnTips.Top;
                panel2.Height = btnTips.Height;
                TipPage();
            }

            private void btnHome_Click(object sender, EventArgs e)
            {
                // Changes the panel to follow button clicks
                panel2.Top = btnHome.Top;
                panel2.Height = btnHome.Height;
                Home();
        }

            private void btnExit_Click(object sender, EventArgs e)
            {
                // Closes the game
                this.Close();
            }

            private void btnStartOver_Click(object sender, EventArgs e)
            {
                // Changes the panel to follow button clicks
                panel2.Top = btnHome.Top;
                panel2.Height = btnHome.Height;

                RestartFunction();
            }

            private void FantasticEnd()
            {
                hide();

                lblHarvested.Show();
                lblRats.Show();
                lblBushelsStore.Show();
                lblTrading.Show();
                lblEnd1.Show();
                lblEnd2.Show();

                AcresPerPerson = Acres / Population;
                PeopleStarvedAverage = PeopleStarvedCount / 10;

                lblAcresOwned.Text = "In your 10 - year term of office, " + PeopleStarvedAverage + " percent of the population starved per year on average,";
                lblHarvested.Text = ".i.e., a total of " + PeopleStarvedCount + " people died!!!";
                lblRats.Text = "You started with 10 acres per person and ended with" + AcresPerPerson + " acres per person";
                lblBushelsStore.Text = "Evaluation:";
                lblTrading.Text = "A fantastic performance!!! Charlemagne, Disraeli and Jefferson combined could not have done better!";

            }
            private void GoodEnd()
            {

                hide();

                lblHarvested.Show();
                lblRats.Show();
                lblTrading.Show();
                lblBushelsStore.Show();
                lblEnd1.Show();
                lblEnd2.Show();
 
                AcresPerPerson = Acres / Population;
                PeopleStarvedAverage = PeopleStarvedCount / 10;

                lblAcresOwned.Text = "In your 10 - year term of office, " + PeopleStarvedAverage + " percent of the population starved per year on average,";
                lblHarvested.Text = ".i.e., a total of " + PeopleStarvedCount + " people died!!!";
                lblRats.Text = "You started with 10 acres per person and ended with " + AcresPerPerson + " acres per person";
                lblBushelsStore.Text = "Evaluation:";
                lblTrading.Text = "Okay performance!!! You almost got kicked out of the office";

            }
            private void BadEnd()
            {

                hide();

                lblHarvested.Show();
                lblTrading.Show();
                lblRats.Show();
                lblBushelsStore.Show();
                lblEnd1.Show();
                lblEnd2.Show();

                AcresPerPerson = Acres / Population;
                PeopleStarvedAverage = PeopleStarvedCount / 10;

                lblAcresOwned.Text = "In your 10 - year term of office, " + PeopleStarvedAverage + " percent of the population starved per year on average,";
                lblHarvested.Text = ".i.e., a total of " + PeopleStarvedCount + " people died!!!";
                lblRats.Text = "You started with 10 acres per person and ended with " + AcresPerPerson + " acres per person";
                lblBushelsStore.Text = "Evaluation:";
                lblTrading.Text = "A bad performance!!! Charlemagne, You managed to get kicked out the office!!!";

            }
            void unhide()
            {
            lblYear.Show();
            lblStarved.Show();
            lblPopulation.Show();
            lblPeopleToCity.Show();
            lblAcresOwned.Show();
            lblBushelsRemaining.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label15.Show();
            txtBuySell.Show();
            txtFeed.Show();
            txtPlant.Show();
            btnNext.Show();
        }
            void hide()
        {
            lblYear.Hide();
            lblStarved.Hide();
            lblPopulation.Hide();
            lblPeopleToCity.Hide();
            lblAcresOwned.Hide();
            lblBushelsRemaining.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            txtBuySell.Hide();
            txtFeed.Hide();
            txtPlant.Hide();
            btnNext.Hide();
            lblBushelsRemaining.Hide();
        }
            private void Plague()
            {

                PlagueRandomChance = random.Next(1, 10);

                if (PlagueRandomChance == 5)
                {
                    Population = Population / 2;
                    lblPlague.Text = "A horrible plague struck! Half the population died.";
                }
                else
                {
                    lblPlague.Text = "";
                }


            }

            private void LeaveRule(object sender, EventArgs e)
            {
                Bushels = BushelStorage;
                Acres = AcresStorage;

                // Checking if textbox leave is Buy or sell
                if (txtBuySell.Text.Length >= 1)
                {
                    // Putting Buy Or Sell TextBox into a variable
                    BuyOrSellInput = int.Parse(txtBuySell.Text);

                    // Checking if input is negative
                    if (BuyOrSellInput < 0) // if input is negative
                    {
                        if (BuyOrSellInput * -1 > Acres) // if input is more than acres owned
                        {
                            MessageBox.Show("You haven't got enough acres!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            return;
                        }
                        else if (BuyOrSellInput * -1 < Acres) // if input is less than acres owned
                        {
                            Acres = Acres + BuyOrSellInput;
                            Bushels = Bushels + ((Trading * BuyOrSellInput) * -1);
                        }
                    }

                    else if (BuyOrSellInput > 0)  // if input is positive
                    {
                        if (BuyOrSellInput * Trading > Bushels) // checks if buy or sell input * trading is more than owned bushels
                        {
                            MessageBox.Show("You haven't got enough bushels!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            return;
                        }
                        else if (BuyOrSellInput * Trading < Bushels) // checks if buy or sell input * trading is less than owned bushels
                        {
                            Acres = Acres + BuyOrSellInput;
                            Bushels = Bushels - (Trading * BuyOrSellInput);

                        }
                    }


                }

                // check if textbox leave is feed
                if (txtFeed.Text.Length >= 1)
                {

                    FeedInput = int.Parse(txtFeed.Text); // input for textbox feed

                    if (FeedInput > Bushels) // checking to see if input for feed is more than owned bushels
                    {
                        MessageBox.Show("You haven't got enough bushels!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else if (FeedInput < Bushels) // Checking to see if input for feed is less than owned bushels
                    {
                        // input away from bushels
                        Bushels = Bushels - FeedInput;
                    }
                }

                // Checking if textbox leave is Planted
                if (txtPlant.Text.Length >= 1)
                {

                    PlantedInput = int.Parse(txtPlant.Text);
                    if (PlantedInput > Acres) // if input is more than acres
                    {
                        MessageBox.Show("Not enough acres!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else if (PlantedInput < Acres) // If input is less than acres
                    {
                        if (PlantedInput > Bushels) // Not enough bushels
                        {
                            MessageBox.Show("Not enough bushels!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            return;
                        }
                        else if (PlantedInput <= Bushels) // making sure input is less or equal to bushels
                        {
                            Bushels = Bushels - PlantedInput;
                        }
                    }
                }

                // Sets the text to equal the calculation after calculations
                lblBushelsRemaining.Text = Bushels + " bushels remaining.";

            }

        void RulePage()
        {
            hide();

            lblYear.Show();
            lblPopulation.Show();
            lblPeopleToCity.Show();
            lblAcresOwned.Show();

            lblYear.Text = "Rules:";
            lblStarved.Text = "";
            lblPeopleToCity.Text = "Rule 1: The game lasts 10 years, with a year being one turn.";
            lblPopulation.Text = "Rule 2: Each year, you will need to Feed/Plant Seeds and you can choose to buy/sell land.";
            lblHarvested.Text = "Rule 3: One Person needs 20 bushels and can farm 10 acres.";
            lblAcresOwned.Text = "Rule 4: Each acre of land requires one bushel of grain to plant seeds.";
            lblRats.Text = "Rule 5: The price to buy/sell land can vary from 17 - 26 bushels.";
            lblBushelsStore.Text = "Rule 6: Do well otherwise the people will overthrow you, and your game will end.";
            lblTrading.Text = "Rule 7: If you make it to the 11th year you will be evaluated on your performance.";


        }
        void Home()
        {
            unhide();

            lblYear.Text = "Year: " + Year + ",";

            lblStarved.Text = PeopleStarved + " people starved.";
            lblAcresOwned.Text = "The city now owns " + Acres + " acres.";
            lblBushelsRemaining.Text = Bushels + " bushels remaining.";
            lblBushelsStore.Text = "You now have " + BushelStorage + " bushels in store.";
            lblTrading.Text = "Land is trading at " + Trading + " bushels per acre.";
            lblPeopleToCity.Text = PeopleToCity + " people came to the city.";
            lblRats.Text = "Rats ate " + Rats + " bushels.";
            lblHarvested.Text = "You harvested " + Harvest + " bushels per acre.";
            lblPopulation.Text = "The city population is now " + Population + ".";
        }

        private void DigitsOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void DigitSymbol(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-')) { 

                e.Handled = true;

            }
        }
    }
}
