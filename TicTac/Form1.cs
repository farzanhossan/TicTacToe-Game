using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a,b,c,d,f,g,h,i,k,j,w;
        int scorex, scorey=0;
        int turns = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // A1
            if(button1.Text=="")
            {
                turns++;
                if(a==0 && k==0)
                {
                    button1.Text = "X";
                    a = 1;
                    k = 1;
                }
                else if(a==0 && k==1)
                {
                    button1.Text = "O";
                    k = 0;
                }
            }
            cheak(button1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            a = b = c = d = f = g = h = i = k = j = w = 0;
           
            turns = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //B1
            if (button2.Text == "")
            {
                turns++;

                if (b == 0 && k == 0)
                {
                    button2.Text = "X";
                    b = 1;
                    k = 1;
                }
                else if (b == 0 && k == 1)
                {
                    button2.Text = "O";
                    k = 0;
                }
            }
            cheak(button2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //C1
            if (button3.Text == "")
            {
                turns++;

                if (c == 0 && k == 0)
                {
                    button3.Text = "X";
                    c = 1;
                    k = 1;
                }
                else if (c == 0 && k == 1)
                {
                    button3.Text = "O";
                    k = 0;
                }
            }
            cheak(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //A2
            if (button4.Text == "")
            {
                turns++;

                if (d == 0 && k == 0)
                {
                    button4.Text = "X";
                    d = 1;
                    k = 1;
                }
                else if (d == 0 && k == 1)
                {
                    button4.Text = "O";
                    k = 0;
                }
            }
            cheak(button4.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                turns++;

                if (f == 0 && k == 0)
                {
                    button5.Text = "X";
                    f = 1;
                    k = 1;
                }
                else if (f == 0 && k == 1)
                {
                    button5.Text = "O";
                    k = 0;
                }
            }
            cheak(button5.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                turns++;

                if (g == 0 && k == 0)
                {
                    button6.Text = "X";
                    g = 1;
                    k = 1;
                }
                else if (g == 0 && k == 1)
                {
                    button6.Text = "O";
                    k = 0;
                }
            }
            cheak(button6.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                turns++;

                if (h == 0 && k == 0)
                {
                    button7.Text = "X";
                    h = 1;
                    k = 1;
                }
                else if (h == 0 && k == 1)
                {
                    button7.Text = "O";
                    k = 0;
                }
            }
            cheak(button7.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                turns++;

                if (i == 0 && k == 0)
                {
                    button8.Text = "X";
                    i = 1;
                    k = 1;
                }
                else if (i == 0 && k == 1)
                {
                    button8.Text = "O";
                    k = 0;
                }
            }
            cheak(button8.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            turns++;

            if (button9.Text == "")
            {
                if (j == 0 && k == 0)
                {
                    button9.Text = "X";
                    j = 1;
                    k = 1;
                }
                else if (j == 0 && k == 1)
                {
                    button9.Text = "O";
                    k = 0;
                }
            }
            cheak(button9.Text);

        }

        public void cheak(string x)
        {
            if((button1.Text==x && button2.Text==x && button3.Text==x) ||
               (button1.Text == x && button5.Text == x && button9.Text == x) ||
                (button1.Text == x && button4.Text == x && button7.Text == x))
            {
                w = 1;
            }

            else if((button3.Text==x && button5.Text==x && button7.Text==x) ||
                (button3.Text == x && button6.Text == x && button9.Text == x))
            {
                w = 1;
            }
            else if((button2.Text == x && button5.Text == x && button8.Text == x))
            {
                w = 1;

            }
            else if ((button4.Text == x && button5.Text == x && button6.Text == x))
            {
                w = 1;

            }
            else if ((button7.Text == x && button8.Text == x && button9.Text == x))
            {
                w = 1;
            }
            else if(turns==9)
            {
                MessageBox.Show("Draw", "Wins");

            }

            if (w==1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                if(x=="X")
                {
                    scorex++;
                    scoreX.Text = scorex.ToString();
                }
                if(x=="O")
                {
                    scorey++;
                    scoreY.Text = scorey.ToString();
                }

                MessageBox.Show(x, "Wins");

            }

        }
    }
}
