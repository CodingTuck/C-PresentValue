using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Present_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool InputIsValid(ref double accumulate, ref double rate, ref int amtYears)
        {
            //Flag variable to indicate whether input is good
            bool inputGood = false;

            //validate user input
            if (double.TryParse(userAccumulateTextBox.Text, out accumulate))
            {
                if (double.TryParse(userInterestRateTextBox.Text, out rate))
                {
                    if (int.TryParse(userYearsTextBox.Text, out amtYears))
                    {
                        //all 3 inputs good?
                        inputGood = true;
                    }
                    else
                    {
                        //display error message for years
                        MessageBox.Show("Years entered is invalid.");
                    }
                }
                else
                {
                    //display error message for interest rate
                    MessageBox.Show("Interest rate amount is invalid.");
                }
            }
            else
            {
                //display error message for the input that the user wants to accumulate
                MessageBox.Show("Accumulate amount is invalid.");
            }
            //return result
            return inputGood;
        
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Initialize Variables and assign them to user input
            double accumulate = 0, rate = 0;
            int amtYears = 0;

            
            if (InputIsValid(ref accumulate, ref rate, ref amtYears))
            {
                accumulate = double.Parse(userAccumulateTextBox.Text);
                rate = double.Parse(userInterestRateTextBox.Text);
                amtYears = int.Parse(userYearsTextBox.Text);

                //Present Value
                double presentValue = PresentValue(accumulate, rate, amtYears);

                //display output of the value in the calculate label
                calculateLabel.Text = "Amount needed to deposit today: " + presentValue.ToString("c");
            }

        }

        private double PresentValue(double accumulate, double rate, int amtYears)
        {
            //calculate presentvalue 
            double presentValue = accumulate / Math.Pow((1 + rate), amtYears);
            return presentValue;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
