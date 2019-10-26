/*
 * Created by: Tobi Adebayo
 * Created on: 25-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows the user to play rock paper scissors against the computer
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

namespace Rock_Paper_Scissors.Tobi
{
    public partial class frmRockPaperScissors : Form
    {
        //Declare local variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            //Creat the random number generator object
            randomNumberGenerator = new Random();

        }

        private void FrmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }
    }
}
