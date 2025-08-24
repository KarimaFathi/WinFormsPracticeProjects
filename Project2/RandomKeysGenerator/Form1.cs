using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandomKeysGenerator
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
            textBoxShowResult.Size = new Size(620, 120);
            textBoxShowResult.Multiline = true;
            textBoxShowResult.ScrollBars = ScrollBars.Vertical;
            lbResult.ForeColor = Color.White;
            grpOptions.ForeColor = Color.White;
            textBoxShowResult.ForeColor = ColorTranslator.FromHtml("#194a7a");
            KeysNumberTextBox.ForeColor = ColorTranslator.FromHtml("#194a7a");
        }

        private void centerControl(Control ctrl)
        {
            ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
        }


        enum enRdChoice { rdSmallLetters = 1, rdCapitalLetters = 2, rdMix = 3 };
        private Random rnd = new Random();

        private void txtNumberOfKeys_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(KeysNumberTextBox.Text, out int numOfKeys) && numOfKeys >= 0)
            {
                errorProvider1.SetError(KeysNumberTextBox, "");
                rdSmallLetters.Enabled = true;
                rdCapitalLetters.Enabled = true;
                rdMix.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(KeysNumberTextBox, "Please enter a valid positive number");
                rdSmallLetters.Enabled = false;
                rdCapitalLetters.Enabled = false;
                rdMix.Enabled = false;
            }
        }

        private char getRandomChar(enRdChoice charType)
        {
            char ch = ' ';
            switch (charType)
            {
                case (enRdChoice.rdSmallLetters):
                    ch = (char)rnd.Next(97, 122);
                    break;

                case (enRdChoice.rdCapitalLetters):
                    ch = (char)rnd.Next(65, 90);
                    break;

                case (enRdChoice.rdMix):
                    do
                    {
                        ch = (char)rnd.Next(65, 123); // A–Z + [\]^_` + a–z
                    } while (ch > 90 && ch < 97);
                    break;
               
            }
            return ch;
        }

       private  string generateWord(enRdChoice charType, short length)
        {
            string word = "";
            for (int i = 1; i <= length; i++)
            {
                word += getRandomChar(charType);
            }
            return word;
        }

        private string generateKey(enRdChoice rdChoice, int numOfBlocks)
        {
            string Key = "";

            for (int i = 0; i < numOfBlocks; i++)
            {
                Key += generateWord(rdChoice, 4) + "-";
            }
            Key = Key.Remove(Key.Length - 1);
            return Key;
        }

        private void generateRandomKeys(int numberOfKeys, enRdChoice rdChoice)
        {
            for (int j = 0; j < numberOfKeys; j++)
                textBoxShowResult.Text += "Key [" + j + "] : " + generateKey(rdChoice, 4) + Environment.NewLine;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (rdSmallLetters.Checked)
            {
                generateRandomKeys((Convert.ToInt32(KeysNumberTextBox.Text)), enRdChoice.rdSmallLetters);
            }
            if (rdCapitalLetters.Checked)
            {
                generateRandomKeys((Convert.ToInt32(KeysNumberTextBox.Text)), enRdChoice.rdCapitalLetters);
            }
            if (rdMix.Checked)
            {
                generateRandomKeys((Convert.ToInt32(KeysNumberTextBox.Text)), enRdChoice.rdMix);
            }

        }
    }
}
