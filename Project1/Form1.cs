using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPracticeProjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#194a7a");
            lbTitle.ForeColor = Color.White;
            centerControl(lbTitle);
            lbShowResult.Size = new Size(800, 100);
            lbResult.ForeColor = Color.White;
            lbShowResult.BackColor = Color.White;
            grpOptions.ForeColor = Color.White;


        }

        private void centerControl(Control ctrl)
        {
            ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
        }

        private void txtNumberOfDigits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DigitsNumberTextBox.Text))
            {
                e.Cancel = true; //I am not letting him to leave the text box
                DigitsNumberTextBox.Focus();
                errorProvider1.SetError(DigitsNumberTextBox, "Please enter the number of digits.");
            }

            else if (!int.TryParse(DigitsNumberTextBox.Text, out int numOfDigits))
            {
                e.Cancel = true; //I am not letting him to leave the text box
                DigitsNumberTextBox.Focus();
                errorProvider1.SetError(DigitsNumberTextBox, "Only numbers are allowed.");

            }
            else if (numOfDigits < 0)
            {
                e.Cancel = true;
                DigitsNumberTextBox.Focus();
                errorProvider1.SetError(DigitsNumberTextBox, "Only positive numbers are allowed.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DigitsNumberTextBox, "");
            }
        }

        private void txtNumberOfDigits_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DigitsNumberTextBox.Text, out int numOfDigits) && numOfDigits >= 0)
            {
                errorProvider1.SetError(DigitsNumberTextBox, "");
                btnLetters.Enabled = true;
                btnNumbers.Enabled = true;
                btnMix.Enabled = true;
                btnSymbols.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(DigitsNumberTextBox, "Please enter a valid positive number");
                btnLetters.Enabled = false;
                btnNumbers.Enabled = false;
                btnMix.Enabled = false;
                btnSymbols.Enabled = false;
            }
        }

        enum enBtnChoice { btnLetters = 1, btnNumbers = 2, btnSymbols = 3, btnMix = 4 };
        private Random rnd = new Random();
        private string generateRandomCharacters(int numOfDigits, enBtnChoice btnChoice, bool isSmallLetters = true)
        {
            string result;
            StringBuilder sb = new StringBuilder();

            switch (btnChoice)
            {
                case enBtnChoice.btnLetters:
                    
                    char start = isSmallLetters ? 'a' : 'A';
                    char end = isSmallLetters ? 'z' : 'Z';
                    for (int j = 0; j < numOfDigits; j++)
                        sb.Append((char)rnd.Next(start, end + 1));
                 break;
                case enBtnChoice.btnNumbers:
                    for (int j = 0; j < numOfDigits; j++)
                    {

                        sb.Append(rnd.Next(0, 10));
                    }
                break;
                case enBtnChoice.btnSymbols:
                    for (int j = 0; j < numOfDigits; j++)
                    {

                        sb.Append((char)rnd.Next(33, 48));
                    }
                    break;
                case enBtnChoice.btnMix:
                    for (int j = 0; j < numOfDigits; j++)
                    {

                        sb.Append((char)rnd.Next(33, 123));
                    }
                break;
            }
            result = sb.ToString();
            return result;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (btnLetters.Checked && (btnLetters.Text == "Small letters" || btnLetters.Text == "Letters")){
                lbShowResult.Text = generateRandomCharacters((Convert.ToInt32(DigitsNumberTextBox.Text)), enBtnChoice.btnLetters);
            }
            if (btnLetters.Checked && btnLetters.Text == "Capital letters"){
                lbShowResult.Text = generateRandomCharacters((Convert.ToInt32(DigitsNumberTextBox.Text)), enBtnChoice.btnLetters, false);
            }
            if (btnNumbers.Checked) {
                lbShowResult.Text = generateRandomCharacters((Convert.ToInt32(DigitsNumberTextBox.Text)), enBtnChoice.btnNumbers);
            }
            if (btnSymbols.Checked)
            {
                lbShowResult.Text = generateRandomCharacters((Convert.ToInt32(DigitsNumberTextBox.Text)), enBtnChoice.btnSymbols);
            }
            if (btnMix.Checked)
            {
                lbShowResult.Text = generateRandomCharacters((Convert.ToInt32(DigitsNumberTextBox.Text)), enBtnChoice.btnMix);
            }
        }

        private void tsmSmallLetters_Click(object sender, EventArgs e)
        {
            btnLetters.Text = "Small letters";
        }

        private void tsmCapitalLetters_Click(object sender, EventArgs e)
        {
            btnLetters.Text = "Capital letters";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DigitsNumberTextBox.Text = "0";
            lbShowResult.Text = "";
            btnLetters.Enabled = false;
            btnNumbers.Enabled = false;
            btnMix.Enabled = false;
            btnSymbols.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void bShowResult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbShowResult.Text))
            {
                Clipboard.SetText(lbShowResult.Text);
                MessageBox.Show("Text copied to clipboard.");
            }
            else
            {
                MessageBox.Show("There is no text to copy.");
            }
        }
    }
}
