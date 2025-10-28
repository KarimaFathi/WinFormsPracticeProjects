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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 form1; // declare a variable for the other form

        public Form2(Form1 f1)
        {
            InitializeComponent();
            form1 = f1; // keep a reference to Form2
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(370, 400);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbLevel.SelectedIndex != -1 && cbOperator.SelectedIndex != -1 && NumUpDownRounds.Value != 0)
            {
                this.Hide();
                form1.Hide();
                Form3 form3 = new Form3(cbLevel.SelectedItem.ToString(), cbOperator.SelectedItem.ToString(), NumUpDownRounds.Value);
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Please complete the options selection.",
                    "Incomplete Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
