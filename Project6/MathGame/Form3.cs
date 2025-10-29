using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form3 : Form
    {
        byte counter = 60;
        byte numOfRounds = 0;

        byte RightAnswers = 0;
        byte WrongAnswers = 0;


        string selectedLevel, selectedOperator;
        decimal selectedNumberOfRounds;
        string rightAnswer;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string level, string operatorChoice, decimal numberOfRounds)
        {
            InitializeComponent();
            selectedLevel = level;
            selectedOperator = operatorChoice;
            selectedNumberOfRounds = numberOfRounds;
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            lbRoundValue.Text =  numOfRounds + "/" + selectedNumberOfRounds.ToString();
            lbLevelValue.Text = selectedLevel;
            lbOperatorChoice.Text = selectedOperator;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            pictureBox1.Image = Properties.Resources.speech_bubbles_with_question_mark_clipart_lg_1_;
            lbOperand1.Visible = true;
            lbOperand2.Visible = true;
            lbOperator.Visible = true;
            lbEqual.Visible = true;
            txtBoxAnswer.Visible = true;
            btnCheckAnswer.Visible = true;
            playRound();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(counter >0)
            {
                counter--;
                lbTimer.Text = counter.ToString();
            } else
            {
                lbTimer.Text = "0";
                timer1.Stop();
                MessageBox.Show("The time has run out!", "Time Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private char GetOperator(string questionOperator)
        {
            Random rnd = new Random();
            switch (questionOperator)
            {
                case "Add":
                    return '+';
                case "Subtract":
                    return '-';
                case "Multiply":
                    return '*';
                case "Divide":
                    return '/';
                case "Mix":
                    char[] Operators = { '+', '-', '*', '/' };
                    return Operators[rnd.Next(Operators.Length)];
            }
            return '+';
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbRightAnswer.Text = rightAnswer;
            lbPlayerAnswer.Text = txtBoxAnswer.Text;
            btnNextQuestion.Visible = true;
            if (lbRightAnswer.Text == lbPlayerAnswer.Text)
            {
                RightAnswers++;
                this.BackColor = Color.LightGreen;
                pictureBox1.Image = Properties.Resources.check_mark_clipart_lg_1_;
            }
            else
            {
                WrongAnswers++;
                this.BackColor = Color.Salmon;
                pictureBox1.Image = Properties.Resources.error_icon_size_512_1_1;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if(numOfRounds < selectedNumberOfRounds)
            {
                playRound();
                this.BackColor = SystemColors.Control;
                pictureBox1.Image = Properties.Resources.speech_bubbles_with_question_mark_clipart_lg_1_;
            }
            else
            {
                MessageBox.Show("The game is over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Click on the Results button to see your final score!", "Score Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4(selectedLevel, selectedOperator, selectedNumberOfRounds, RightAnswers, WrongAnswers);
            form4.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 60;
            lbTimer.Text = counter.ToString(); // update UI
            timer1.Stop();
            txtBoxAnswer.Text = "";
            btnNextQuestion.Visible = false;
            btnStart.Visible = true;
            btnCheckAnswer.Visible = false;
            lbRightAnswer.Text = "0";
            lbPlayerAnswer.Text = "0";
            numOfRounds = 0;
            lbRoundValue.Text = numOfRounds + "/" + selectedNumberOfRounds;
            pictureBox1.Image = Properties.Resources.mathematics_stationery_clipart_md_1_;
            this.BackColor = SystemColors.Control;
            lbOperand1.Visible = false;
            lbOperand2.Visible = false;
            lbOperator.Visible = false;
            lbEqual.Visible = false;

        }

        private void playRound()
        {
            txtBoxAnswer.Text = "";
            Random rnd = new Random();
            int questionRightAnswer = 0;
            counter = 60;
            lbTimer.Text = counter.ToString(); // update UI
            timer1.Start();
            numOfRounds++;
            lbRoundValue.Text = numOfRounds + "/" + selectedNumberOfRounds;
            lbOperator.Text = GetOperator(selectedOperator).ToString();
            char op = Convert.ToChar(lbOperator.Text);
            switch (selectedLevel)
            {
                case "Easy":
                    lbOperand1.Text = rnd.Next(1, 10).ToString();
                    lbOperand2.Text = rnd.Next(1, 10).ToString();
                    break;

                case "Medium":
                    lbOperand1.Text = rnd.Next(10, 51).ToString();
                    lbOperand2.Text = rnd.Next(10, 51).ToString();
                    break;

                case "Hard":
                    lbOperand1.Text = rnd.Next(50, 150).ToString();
                    lbOperand2.Text = rnd.Next(50, 150).ToString();
                    break;

                case "Mix":
                    lbOperand1.Text = rnd.Next(1, 150).ToString();
                    lbOperand2.Text = rnd.Next(1, 150).ToString();
                    break;
            }
            int operand1 = Convert.ToInt16(lbOperand1.Text);
            int operand2 = Convert.ToInt16(lbOperand2.Text);

            switch (op)
            {
                case '+':
                    questionRightAnswer = operand1 + operand2;
                    break;
                case '-':
                    questionRightAnswer = operand1 - operand2;
                    break;
                case '*':
                    questionRightAnswer = operand1 * operand2;
                    break;
                case '/':
                    // Prevent division by zero
                    questionRightAnswer = operand2 != 0 ? operand1 / operand2 : 0;
                    break;
            }

            // (optional) Display or store the correct answer
            rightAnswer = questionRightAnswer.ToString();

        }

       
    }
}


