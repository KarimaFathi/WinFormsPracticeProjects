using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKeyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBeforeEncrypt.Multiline = true;
            txtBeforeEncrypt.Height = 50;
            txtBeforeDecrypt.Multiline = true;
            txtBeforeDecrypt.Height = 50;
            txtAfterEncrypt.Multiline = true;
            txtAfterEncrypt.Height = 50;
            txtAfterDecrypt.Multiline = true;
            txtAfterDecrypt.Height = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.ClientSize = new Size(900, 600);
            lbTitle.Left = (this.ClientSize.Width - lbTitle.Width) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tm = DateTime.Now;
            lbCurrentDate.Text = tm.ToString("yyyy-MM-dd HH:mm:ss tt");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbTrackValue.Text = trackBar1.Value.ToString();
        }


        private string encryptText(string text, int encryptionKey)
        {
            string newString = "";
            for (int i = 0; i < text.Length; i++)
            {
                newString += (char)((int)(text[i]) + encryptionKey);
            }
            return newString;
        }

        private string decryptText(string text, int encryptionKey)
        {
            string newString = "";
            for (int i = 0; i < text.Length; i++)
            {
                newString += (char)((int)(text[i] - encryptionKey));
            }
            return newString;
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtBeforeEncrypt.Text))
            {
                MessageBox.Show(
                "Please enter text for encryption",   // Message
                "Input Required",                     // Title (caption)
                MessageBoxButtons.OK,                 // Buttons
                MessageBoxIcon.Warning                // Icon
            );
            }
            else
            {
                if (int.TryParse(lbTrackValue.Text, out int trackValue) == true)
                {
                    btnEncrypt.Visible = false;
                    lbEncryptProgress.Visible = true;
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Minimum = 0;
                    for (int i = 0; i <= 10; i++)
                    {

                        if (progressBar1.Value < progressBar1.Maximum)
                        {
                            Thread.Sleep(100);
                            progressBar1.Value += 10;
                            lbEncryptProgress.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                            progressBar1.Refresh();
                            lbEncryptProgress.Refresh();
                        }
                        else
                        {
                            lbEncryptProgress.Visible = false;
                            progressBar1.Visible = false;
                            btnEncrypt.Visible = true;
                            MessageBox.Show(
                            "Text Encrypted",   // Message
                            "Encryption Done",                     // Title (caption)
                            MessageBoxButtons.OK,                 // Buttons
                            MessageBoxIcon.Information);                // Icon
                        }
                    }

                    txtAfterEncrypt.Text = encryptText(txtBeforeEncrypt.Text, Convert.ToInt16(lbTrackValue.Text));
                }
                else
                {
                    MessageBox.Show(
                     "Track value is unselected",   // Message
                     "Error",                     // Title (caption)
                     MessageBoxButtons.OK,                 // Buttons
                     MessageBoxIcon.Error);                // Icon

                }

            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBeforeDecrypt.Text))
            {
                MessageBox.Show(
                "Please enter text for decryption",   // Message
                "Input Required",                     // Title (caption)
                MessageBoxButtons.OK,                 // Buttons
                MessageBoxIcon.Warning                // Icon
            );
            }
            else
            {
                if (int.TryParse(lbTrackValue.Text, out int trackValue) == true)
                {
                    btnDecrypt.Visible = false;
                    lbDecryptProgress.Visible = true;
                    progressBar2.Visible = true;
                    progressBar2.Value = 0;
                    progressBar2.Maximum = 100;
                    progressBar2.Minimum = 0;
                    for (int i = 0; i <= 10; i++)
                    {

                        if (progressBar2.Value < progressBar2.Maximum)
                        {
                            Thread.Sleep(100);
                            progressBar2.Value += 10;
                            lbDecryptProgress.Text = (((float)progressBar2.Value / progressBar2.Maximum) * 100) + "%";
                            progressBar2.Refresh();
                            lbDecryptProgress.Refresh();
                        }
                        else
                        {
                            lbDecryptProgress.Visible = false;
                            progressBar2.Visible = false;
                            btnDecrypt.Visible = true;
                            MessageBox.Show(
                            "Text Decrypted",   // Message
                            "Decryption Done",                     // Title (caption)
                            MessageBoxButtons.OK,                 // Buttons
                            MessageBoxIcon.Information);                // Icon
                        }
                    }

                    txtAfterDecrypt.Text = decryptText(txtBeforeDecrypt.Text, Convert.ToInt16(lbTrackValue.Text));
                }
                else
                {
                    MessageBox.Show(
                     "Track value is unselected",   // Message
                     "Error",                     // Title (caption)
                     MessageBoxButtons.OK,                 // Buttons
                     MessageBoxIcon.Error);                // Icon

                }

            }
        }

        private void tsmClearAll_Click(object sender, EventArgs e)
        {
            txtBeforeEncrypt.Clear();
            txtAfterEncrypt.Clear();
            txtBeforeDecrypt.Clear();
            txtAfterDecrypt.Clear();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmCopy_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)contextMenuStrip2.SourceControl;
            Clipboard.SetText(txtBox.SelectedText);
            

        }

        private void tsmPast_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)contextMenuStrip2.SourceControl;
            txtBox.SelectedText = Clipboard.GetText();

        }

        private void tsmCut_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)contextMenuStrip2.SourceControl;
            txtBox.SelectedText = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
