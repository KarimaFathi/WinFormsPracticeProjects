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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            this.ClientSize = new Size(850, 500);
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static void ShowCentered(Form child, Form parent)
        {
            // Calculate position so the child appears centered on the parent
            child.StartPosition = FormStartPosition.Manual;

            // If the child’s size isn’t finalized yet, adjust it after Load
            child.Load += (s, e) =>
            {
                int x = parent.Location.X + (parent.Width - child.Width) / 2;
                int y = parent.Location.Y + (parent.Height - child.Height) / 2;

                child.Location = new Point(x, y);
            };

            // Show the form modally with its parent
            child.ShowDialog(parent);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ShowCentered(new Form2(this), this);
            
        }
    }
}
