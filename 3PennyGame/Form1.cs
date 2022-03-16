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
    public partial class Form1 : Form
    {
        Image file;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file = Image.FromFile("C:\\Users\\user\\source\\repos\\3PennyGame\\Images\\mainmenu.jpg");
            pictureBox1.Image = file;
        }

        private void stdPlay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f = new Form3();
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 f = new Form4();
            f.Visible = true;
        }
    }
}
