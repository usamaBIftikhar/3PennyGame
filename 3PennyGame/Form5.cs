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
    public partial class Form5 : Form
    {
        int i = 0;
        int j = 0;
        Player p;
        Computer c;
        String WinnerName;
        bool isWin = false;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(String f, String s, String t)
        {
            InitializeComponent();
            p = new Player(f, s, t);
            t = s;
            if (s == "H")
            {
                s = "T";
            }
            else
            {
                s = "H";
            }
            c = new Computer(s,f,t);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            p1.Text = p.GetFirst();
            p2.Text = p.GetSecond();
            p3.Text = p.GetThird();
            c1.Text = c.GetFirst();
            c2.Text = c.GetSecond();
            c3.Text = c.GetThird();
            timer1.Enabled = true;
            roundLab.Text = "Round: " + j + 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b1.Text == "H")
            {
                b1.Text = "T";
            }
            else
            {
                b1.Text = "H";
            }
            if (b2.Text == "H")
            {
                b2.Text = "T";
            }
            else
            {
                b2.Text = "H";
            }
            if (b3.Text == "H")
            {
                b3.Text = "T";
            }
            else
            {
                b3.Text = "H";
            }
            if(i==10)
            {
                timer1.Enabled = false;
                Random rnd = new Random();
                Random rnd2 = new Random();
                Random rnd3 = new Random();
                int n1 = rnd.Next(10);
                int n2 = rnd.Next(10);
                int n3 = rnd.Next(10);
                if (n1 < 5)
                    b1.Text = "T";
                else
                    b1.Text = "H";
                if (n2 < 5)
                    b2.Text = "T";
                else
                    b2.Text = "H";
                if (n3 < 5)
                    b3.Text = "T";
                else
                    b3.Text = "H";
                i = 0;

                if (p.ComparePlayer(b1.Text, b2.Text, b3.Text))
                {
                    WinnerName = "Player";
                    isWin = true;
                    winLab.Text = WinnerName + " Wins the Game.....";
                }
                else if (c.CompareComputer(b1.Text, b2.Text, b3.Text))
                {
                    WinnerName = "Computer";
                    isWin = true;
                    winLab.Text = WinnerName + " Wins the Game.....";
                }

            }
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isWin == false && j < 9)
            {
                j = j+1;
                roundLab.Text = "Round: " + (j + 1);
                timer1.Enabled = true;
            }
            else if(isWin == true)
            {
                winLab.Text = WinnerName + " Wins the Game.....";
                this.Visible = false;
                Form1 f = new Form1();
                f.Visible = true;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.Visible = true;
        }
    }
}
