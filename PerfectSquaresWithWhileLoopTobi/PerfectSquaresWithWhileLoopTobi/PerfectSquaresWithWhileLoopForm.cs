/*
 * Created by: Tobi Adebayo
 * Created on: 26-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day 23 - Perfect Squares with While Loop
 * This program lists the perfect squares between 0 and the number the user entered
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

namespace PerfectSquaresWithWhileLoopTobi
{
    public partial class frmPerfectSquaresWithWhileLoop : Form
    {
        public frmPerfectSquaresWithWhileLoop()
        {
            InitializeComponent();
        }

        private void frmPerfectSquaresWithWhileLoop_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // set the initial value to 0
            value = 0;

            // clear items in thelist box
            this.lstPerfectSquares.Items.Clear();

            // get the user's end value from the up-down box
            endingValue = Convert.ToInt32(this.nudNumber.Value);

            // continue stating any perfect squares between the min and user's selected value
            while (value <= endingValue)
            {
                // increment the value by 1
                value = value + 1;

                // take the square root 
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // The value has to be a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");

                    // refresh form
                    this.Refresh();
                }
            }
        }
    }
}