/*
 * Created by: Tobi Adebayo
 * Created on: 27-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day 24 - Unicode
 * This program takes the letters from A to Z along with the Unicode value attached to it and places them in the list box
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

namespace UnicodeTobi
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void frmUnicode_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            string letters;
            int letterCounter;

            // Clear the items in listbox
            this.lstUnicode.Items.Clear();

            // Create loop 
            for (letterCounter = 65; letterCounter <= 90; letterCounter++)
            {
                // convert the counter to unicode letter
                letters = Char.ConvertFromUtf32(letterCounter);

                // Add letter with its value to the listbox
                this.lstUnicode.Items.Add(letters + " -> " + letterCounter);
            }

        }
    }
}
