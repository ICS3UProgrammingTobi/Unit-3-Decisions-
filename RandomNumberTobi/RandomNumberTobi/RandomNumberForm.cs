using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberTobi
{
    public partial class frmRandomNumberUpdated : Form
    {
        public frmRandomNumberUpdated()
        {
            InitializeComponent();
            //Hide the label
            lblAnswer.Hide();

            //Declare local variables
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            int usernumber;
            Random randomnumberGenerator = new Random();

            //Get the random number
            aRandomNumber = randomnumberGenerator.Next(MIN_NUM, MAX_NUM+1);

            //Assign to a label
            lblAnswer.Text = Convert.ToString(aRandomNumber);

            usernumber = int.Parse(txtAnswer.Text);


            //If the number guessed is correct or wrong
            if(aRandomNumber==usernumber)
            {
                this.lblAnswer.Text = "You guessed correctly!";
            }
            else
            {
                this.lblAnswer.Text = "Sorry, try again.";
            }


              

            
                
                
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Show the label
            lblAnswer.Show();


        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
