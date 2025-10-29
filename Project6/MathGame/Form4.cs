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
    public partial class Form4 : Form
    {
        byte correctAnswers;
        byte badAnswers;
        decimal rounds;
        string questionOperator;
        string level;
        decimal scorePercentage;

        public Form4()
        {
            InitializeComponent();
        }


        public Form4(string selectedLevel, string selectedOperator, decimal selectedNumberOfRounds, byte RightAnswers, byte WrongAnswers)
        {
            InitializeComponent();
            level = selectedLevel;
            correctAnswers = RightAnswers;
            badAnswers = WrongAnswers;
            questionOperator = selectedOperator;
            rounds = selectedNumberOfRounds;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbLevel.Text = level;
            lbOperator.Text = questionOperator;
            lbRounds.Text = rounds.ToString();
            lbNumberOfQuestions.Text = rounds.ToString();
            lbRightAnswers.Text = correctAnswers.ToString();
            lbWrongAnswers.Text = badAnswers.ToString();
            scorePercentage = Math.Round((correctAnswers / rounds) * 100, 1);
            lbScore.Text = scorePercentage.ToString() + "% -";
            if(scorePercentage < 50)
            {
                lbPerformance.Text = "Fail";
            }
            else if(scorePercentage < 70)
            {
                lbPerformance.Text = "Acceptable";
            } else if(scorePercentage < 90)
            {
                lbPerformance.Text = "Very Good";
            } else
            {
                lbPerformance.Text = "Excellent";
            }
        }



    }
}
