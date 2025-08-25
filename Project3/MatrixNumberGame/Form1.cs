using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixNumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 600);
            centerControl(lbNumberToFind);


        }
        private void centerControl(Control ctrl)
        {
            ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
        }


        private void generateMatrix()
        {

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Label lbl = new Label();
                    lbl.Name = $"lbMatrix_{i}_{j}";
                    lbl.AutoSize = false;
                    lbl.Size = new System.Drawing.Size(47, 47);
                    lbl.BackColor = Color.PaleVioletRed;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Location = new Point(70 * i + 303, 70 * j + 30);
                    lbl.ForeColor = Color.Black;
                    lbl.Text = rnd.Next(0, 10).ToString();
                    lbl.Font = new Font("Microsoft YaHei UI", 11, FontStyle.Bold);


                    panel.Controls.Add(lbl);
                }
            }

        }

        private void deleteExistingMatrix()
        {
            foreach (Label lbl in panel.Controls.OfType<Label>())
            {
                if (lbl.Name.StartsWith("lbMatrix"))
                {
                    panel.Controls.Remove(lbl);
                }
            }
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            deleteExistingMatrix();
            generateMatrix();
            lbNumberToFind.Text = rnd.Next(0, 10).ToString();
            lbShowResult.Text = "";
            lbRightAnswer.Text = "";
            txBoxAnswer.Text = "";
        }

        private int CountNumberInMatrix()
        {
            int counter = 0;
            foreach (Label lbl in panel.Controls.OfType<Label>())
            {
                if (lbl.Name.StartsWith("lbMatrix") && lbl.Text == lbNumberToFind.Text)
                {
                    counter++;
                }
            }
            return counter;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int NumberOccurrenceInMatrix = CountNumberInMatrix();
            if (NumberOccurrenceInMatrix == Convert.ToInt32(txBoxAnswer.Text))
            {
                lbShowResult.Text = "Correct Answer";
                lbShowResult.ForeColor = Color.Green;
            }
            else
            {
                lbShowResult.Text = "Wrong Answer";
                lbShowResult.ForeColor = Color.Red;
                lbRightAnswer.Text = "The correct answer is : " + NumberOccurrenceInMatrix;
            }
        }

        private void txBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txBoxAnswer.Text, out int numOfOccurence) && numOfOccurence >= 0)
            {
                errorProvider1.SetError(txBoxAnswer, "");

            }
            else
            {
                errorProvider1.SetError(txBoxAnswer, "Please enter a valid positive number");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
