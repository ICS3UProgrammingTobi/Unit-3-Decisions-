/*
 * Created by: Tobi adebayo
 * Created on: 27-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the color of each object on th form
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

namespace ForEachwithControlObjectsTobi
{
    public partial class frmForEachWithControlObjects : Form
    {
        public frmForEachWithControlObjects()
        {
            InitializeComponent();
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it Yellow
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Yellow;
            }
        }

        private void lblChangeColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it orange
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Orange;

            }
        }
    }
}
