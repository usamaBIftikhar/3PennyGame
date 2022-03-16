using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PennyGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (h1.Text == "H")
            {
                h1.Text = "T";
            }
            else
            {
                h1.Text = "H";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (h2.Text == "H")
            {
                h2.Text = "T";
            }
            else
            {
                h2.Text = "H";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (h3.Text == "H")
            {
                h3.Text = "T";
            }
            else
            {
                h3.Text = "H";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 f = new Form5(h1.Text, h2.Text, h3.Text);
            f.Visible = true;
        }
    }
}
