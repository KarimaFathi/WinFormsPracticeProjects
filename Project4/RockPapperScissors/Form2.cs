using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPapperScissors
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void txtBoxNumberOfRounds_TextChanged(object sender, EventArgs e)
        {
            if (byte.TryParse(txtBoxNumberOfRounds.Text, out byte numOfRounds) && numOfRounds > 0)
            {
                errorProvider1.SetError(txtBoxNumberOfRounds, "");
                panel3.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtBoxNumberOfRounds, "Please enter a valid positive number");

            }
        }

        enum enChoice { rock = 1, paper = 2, scissors = 3 };
        Random rnd = new Random();
        private void startGame(byte numberOfRounds)
        {
            if(Convert.ToByte(lbRoundCounter.Text) < numberOfRounds)
            {

                enChoice computerChoice = (enChoice)Convert.ToByte(rnd.Next(1, 4));
                getComputerPicture(computerChoice);

                if ((rdRock.Checked && computerChoice == enChoice.scissors) || (rdScissors.Checked && computerChoice == enChoice.paper) || (rdPaper.Checked && computerChoice == enChoice.rock)) {
                    lbPlayerWinCounter.Text = (Convert.ToByte(lbPlayerWinCounter.Text) + 1).ToString();
                    panel2.BackColor = Color.LightGreen;
                    lbWinner.Text = "Player";
                } 
                else if ((rdRock.Checked && computerChoice == enChoice.rock) || (rdScissors.Checked && computerChoice == enChoice.scissors) || (rdPaper.Checked && computerChoice == enChoice.paper))
                {
                    lbDrawCounter.Text = (Convert.ToByte(lbDrawCounter.Text) + 1).ToString();
                    panel2.BackColor = Color.NavajoWhite;
                    lbWinner.Text = "Draw";
                }
                else
                {
                    lbComputerWinCounter.Text = (Convert.ToByte(lbComputerWinCounter.Text) + 1).ToString();
                    panel2.BackColor = Color.Salmon;
                    lbWinner.Text = "Computer";

                }
                lbRoundCounter.Text = Convert.ToByte(lbRoundCounter.Text) == numberOfRounds ? lbRoundCounter.Text : (Convert.ToByte(lbRoundCounter.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Game Over");
                showFinalResults();
            }
            
        }

        private void showFinalResults()
        {
            groupBox1.Visible = true;
            lbFinalGameRounds.Text = txtBoxNumberOfRounds.Text;
            lbFinalPlayerWonTimes.Text = lbPlayerWinCounter.Text;
            lbFinalComputerWonTimes.Text = lbComputerWinCounter.Text;
            lbFinalDrawTimes.Text = lbDrawCounter.Text;

            if (Convert.ToByte(lbPlayerWinCounter.Text) > Convert.ToByte(lbComputerWinCounter.Text))
            {
                lbFinalWinner.Text = "Player";
                panel2.BackColor = Color.LightGreen;
            }
            else if (Convert.ToByte(lbPlayerWinCounter.Text) < Convert.ToByte(lbComputerWinCounter.Text))
            {
                lbFinalWinner.Text = "Computer";
                panel2.BackColor = Color.Salmon;
            }
            else
            {
                lbFinalWinner.Text = "Draw";
                lbWinner.Text = "Draw";
            }
        }


        private void getComputerPicture(enChoice computerChoice)
        {
            if (computerChoice == enChoice.rock)
            {
                picBoxComputer.Image = Properties.Resources.Coal_25705;
            }
            if (computerChoice == enChoice.paper)
            {
                picBoxComputer.Image = Properties.Resources._1499345633_plain_paper_85356;
            }
            if (computerChoice == enChoice.scissors)
            {
                picBoxComputer.Image = Properties.Resources.fullcut_cut_scissors_4720;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame(Convert.ToByte(txtBoxNumberOfRounds.Text));
        }

        private void rdRock_CheckedChanged(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Coal_25705;
        }

        private void rdPaper_CheckedChanged(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources._1499345633_plain_paper_85356;
        }

        private void rdScissors_CheckedChanged(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.fullcut_cut_scissors_4720;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Azure;
            txtBoxNumberOfRounds.Text = "";
            errorProvider1.SetError(txtBoxNumberOfRounds, "");
            panel3.Enabled = false;
            lbComputerWinCounter.Text = "0";
            lbDrawCounter.Text = "0";
            lbPlayerWinCounter.Text = "0";
            lbRoundCounter.Text = "0";
            groupBox1.Visible = false;
            picBoxComputer.Image = Properties.Resources.question_mark_96;
            picBoxPlayer.Image = Properties.Resources.question_mark_96;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
