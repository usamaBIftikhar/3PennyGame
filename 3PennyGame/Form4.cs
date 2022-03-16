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
    public partial class Form4 : Form
    {
        Image file;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            file = Image.FromFile("C:\\Users\\user\\source\\repos\\3PennyGame\\Images\\help.png");
            pictureBox1.Image = file;
        }
    }
}
