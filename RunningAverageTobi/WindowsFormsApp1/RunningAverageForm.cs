/*
 * Created by: Tobi Adebayo
 * Created on: 27-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program calculates the average of the numbers the user entered
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRunningAverage : Form
    {
        // set the variables
        double sum = 0;
        double userinputs = 0;
        public frmRunningAverage()
        {

            InitializeComponent();
            //hide tthe label
            this.lblAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Show the label
            this.lblAnswer.Show();

            // declare local variables
            double userValue;
            double average;

            // get the user's number 
            userValue = double.Parse(txtAvrage.Text);

            // increment the number
            userinputs++;

            // calculate the average
            sum = sum + userValue;
            average = sum / userinputs;

            // display the average of the running
            lblAnswer.Text = Convert.ToString(average);

            // if the user enters -1, display a Goodbye message and disable buttons
            if (userValue == -1)
            {
                MessageBox.Show("Running average ended.", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtAvrage.Visible = false;
                this.Close();
            }
        }

        private void frmRunningAverage_Load(object sender, EventArgs e)
        {

        }
    }
}
