/*
 * Created by: Tobi adebayo
 * Created on: 27-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day 23 - Factorial with For Loop
 * This program calculates the factorial of a number that uses a for loop.
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

namespace FactorialwithForLoopTobi
{
    public partial class frmFactorialWithForLoop : Form
    {
        public frmFactorialWithForLoop()
        {
            InitializeComponent();
            //Hide the label
            this.lblAnswer.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // show the text
            lblAnswer.Show();

            // declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumber.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // Get the number from user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // Display numbers
                this.lstFactorialNumber.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            // Convert the factorialAnswer to a String and add it to a label
            this.lblAnswer.Text = this.txtNumber.Text + "! =" + Convert.ToString(factorialAnswer);

            
        }
    }
}
