using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_si_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        MessageBoX M = new MessageBoX();
        int k = 0;
        int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            if (a8 == 0)
            {
                if (k % 2 == 0)
                {
                    button8.Text = "X";
                    k++;
                    a8 = 1;
                    if (this.button7.Text == "X" && this.button9.Text == "X" || (this.button2.Text == "X" && this.button5.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button8.Text = "0";
                    k++;
                    a8 = 1;
                    if (this.button7.Text == "0" && this.button9.Text == "0" || (this.button2.Text == "0" && this.button5.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (a7 == 0)
            {
                if (k % 2 == 0)
                {
                    this.button7.Text = "X";
                    k++;
                    a7 = 1;
                    if (this.button9.Text == "X" && this.button8.Text == "X" || (this.button1.Text == "X" && this.button4.Text == "X") || (this.button5.Text == "X" && this.button3.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    this.button7.Text = "0";
                    k++;
                    a7 = 1;
                    if (this.button1.Text == "0" && this.button4.Text == "0" || (this.button8.Text == "0" && this.button9.Text == "0") || (this.button5.Text == "0" && this.button3.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a6 == 0)
            {
                if (k % 2 == 0)
                {
                    button6.Text = "X";
                    k++;
                    a6 = 1;
                    if (this.button4.Text == "X" && this.button5.Text == "X" ||  (this.button3.Text == "X" && this.button9.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }               
                }
                else
                {
                    button6.Text = "0";
                    k++;
                    a6 = 1;
                    if ((this.button4.Text == "0" && this.button5.Text == "0") || (this.button3.Text == "0" && this.button9.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a5 == 0)
            {
                if (k % 2 == 0)
                {
                    button5.Text = "X";
                    k++;
                    a5 = 1;
                    if (this.button2.Text == "X" && this.button8.Text == "X" || (this.button4.Text == "X" && this.button6.Text == "X") || (this.button1.Text == "X" && this.button9.Text == "X") || (this.button3.Text == "X" && this.button7.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button5.Text = "0";
                    k++;
                    a5 = 1;
                    if (this.button2.Text == "0" && this.button8.Text == "0" || (this.button4.Text == "0" && this.button6.Text == "0") || (this.button1.Text == "0" && this.button9.Text == "0") || (this.button3.Text == "0" && this.button7.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (a4 == 0)
            {
                if (k % 2 == 0)
                {
                    button4.Text = "X";
                    k++;
                    a4 = 1;
                    if (this.button5.Text == "X" && this.button6.Text == "X" || (this.button1.Text == "X" && this.button7.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button4.Text = "0";
                    k++;
                    a4 = 1;
                    if (this.button5.Text == "0" && this.button6.Text == "0" || (this.button1.Text == "0" && this.button7.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a1 == 0)
            {
                if (k % 2 == 0)
                {
                    button1.Text = "X";
                    k++;
                    a1 = 1;
                    if (this.button4.Text == "X" && this.button7.Text == "X" || (this.button2.Text == "X" && this.button3.Text == "X") || (this.button5.Text == "X" && this.button9.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button1.Text = "0";
                    k++;
                    a1 = 1;
                    if (this.button2.Text == "0" && this.button3.Text == "0" || (this.button4.Text == "0" && this.button7.Text == "0") || (this.button5.Text == "0" && this.button9.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (a2 == 0)
            {
                if (k % 2 == 0)
                {
                    button2.Text = "X";
                    k++;
                    a2 = 1;
                    if (this.button1.Text == "X" && this.button3.Text == "X" || (this.button5.Text == "X" && this.button8.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button2.Text = "0";
                    k++;
                    a2 = 1;
                    if (this.button1.Text == "0" && this.button3.Text == "0" || (this.button5.Text == "0" && this.button8.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (a3 == 0)
            {
                if (k % 2 == 0)
                {
                    button3.Text = "X";
                    k++;
                    a3 = 1;
                    if (this.button1.Text == "X" && this.button2.Text == "X" || (this.button6.Text == "X" && this.button9.Text == "X") || (this.button5.Text =="X" && this.button7.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button3.Text = "0";
                    k++;
                    a3 = 1;
                    if (this.button1.Text == "0" && this.button2.Text == "0" || (this.button6.Text == "0" && this.button9.Text == "0") || (this.button5.Text == "0" && this.button7.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (a9 == 0)
            {
                if (k % 2 == 0)
                {
                    button9.Text = "X";
                    k++;
                    a9 = 1;
                    if (this.button6.Text == "X" && this.button3.Text == "X" || (this.button8.Text == "X" && this.button7.Text == "X") || (this.button5.Text == "X" && this.button1.Text == "X"))
                    {
                        this.Visible = false;
                        M.show("X WON!!");
                        M.ShowDialog();
                    }
                }
                else
                {
                    button9.Text = "0";
                    k++;
                    a9 = 1;
                    if (this.button6.Text == "0" && this.button3.Text == "0" || (this.button8.Text == "0" && this.button7.Text == "0") || (this.button5.Text == "0" && this.button1.Text == "0"))
                    {
                        this.Visible = false;
                        M.show("0 WON!!");
                        M.ShowDialog();
                    }
                }
            }
        }
    }
}
