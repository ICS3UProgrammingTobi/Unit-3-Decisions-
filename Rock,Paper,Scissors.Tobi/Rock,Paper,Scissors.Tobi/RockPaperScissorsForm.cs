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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 3;

            // get the user's Choice, if there is no selection set it to 0
            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }
            // randomly generate a number representatng cpu choice
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the radio button for the computer
            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else
            {
                this.radComputerScissors.Checked = true;
            }
        }
    }
}
