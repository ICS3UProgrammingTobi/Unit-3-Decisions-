/*
 * Created by: Tobi Adebayo
 * Created on: 26-10-219
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program factors a number the user enters
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

namespace FactorialDoWhileTobi
{
    public partial class frmFactorialDoWhle : Form
    {
        public frmFactorialDoWhle()
        {
            InitializeComponent();
            //Hide labe
            this.lblAnswer.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Show label
            this.lblAnswer.Show();

            // declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumber.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the next incremented 
            do
            {
                // increment the counter by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in the listbox for the user to see
                lstFactorialNumber.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < factorialNumber);

            // convert the factorialAnswer to a String and insert it into the label
            this.lblAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);

        }
    }
}
