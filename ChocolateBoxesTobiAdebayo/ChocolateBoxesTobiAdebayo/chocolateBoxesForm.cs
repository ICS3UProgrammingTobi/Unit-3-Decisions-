/*
 * Created by: Tobi adebayo
 * Created on: 26-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program tells the user what prize they got depending on the # of boxes they sold
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

namespace ChocolateBoxesTobiAdebayo
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            //Hide label
            this.lblReward.Hide();
        }

        private void LblBoxes_Click(object sender, EventArgs e)
        {

        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            //Show label
            this.lblReward.Show();

            //Declare variables and constants
            int Boxes;

            //link it to the text box
            Boxes = int.Parse(txtNumberOfBoxes.Text);

            //Show the prizes
            if (Boxes>20)
            {
                lblReward.Text = "You get a prize!";
            }
            else if (Boxes<10)
            {
                lblReward.Text = "You recived and honorable mention";
            }
            else
            {
                lblReward.Text = "You get a small prize!";
            }

        }
    }
}
