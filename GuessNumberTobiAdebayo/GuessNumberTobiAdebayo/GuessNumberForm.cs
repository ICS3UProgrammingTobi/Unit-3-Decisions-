/*
     * Created by: Tobi Adebayo
     * Created on: 17-10-2019
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Guess The Number
     * This program allows the user to guess a random number the computer generated
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

namespace GuessNumberTobiAdebayo
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();
            //Hide the label
            this.lblRight.Hide();
            this.lblWrong.Hide();
            this.picCheck.Hide();
            this.picX.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Declare constants and variables
            const int SCREAT_NUMBER = 5;
            int number;

            //get the users number
            number = int.Parse(txtAnswer.Text);

            //If the number guessed is correct or wrong
            if(number== SCREAT_NUMBER) 
            {
                lblRight.Show();
                picCheck.Show();
                lblWrong.Hide();
                picX.Hide();
                
            }
            else
            {
                lblWrong.Show();
                picX.Show();
                lblRight.Hide();
                picCheck.Hide();

            }



            

                
            

        }
    }
}
