/*
 * Created by: Tobi Adebayo
 * Created on: 27-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program displays all the letters of the alphabet from A to Z and write all the letters from a to z beside it
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

namespace NestedLoopsTobi
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int capitalCounter;
            int lowerCounter;
            string capital;
            string lowercase;

            // clear listbox
            this.lstAlphabets.Items.Clear();

            // loop throught the capital letters from 65 to 90
            for (capitalCounter = 65; capitalCounter <= 90; capitalCounter++)
            {
                // For each of the lower alphabets, loop through 97 to 122 and add it beside the capital letters
                for (lowerCounter = 97; lowerCounter <= 122; lowerCounter++)
                {
                    capital = Char.ConvertFromUtf32(capitalCounter);
                    lowercase = Char.ConvertFromUtf32(lowerCounter);

                    // display in the listbox
                    this.lstAlphabets.Items.Add(capitalCounter + " -> " + lowerCounter);
                }
            }
        }
    }
}

