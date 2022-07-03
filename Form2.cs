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
    public partial class MessageBoX : Form
    {
        public MessageBoX()
        {
            InitializeComponent();
        }
        public void show(string potat)
        {
            this.label1.Text = potat;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;            
            Form1 OWO = new Form1();
            OWO.ShowDialog();
        }

        private void Joe_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            Form3 f2 = new Form3();
            Form3 f3 = new Form3();
            Form3 f4 = new Form3();
            Form3 f5 = new Form3();
            Form3 f6 = new Form3();
            f1.ShowDialog();
            f2.ShowDialog();
            f3.ShowDialog();
            f4.ShowDialog();
            f5.ShowDialog();
            f6.ShowDialog();
            for (int i = 0; i < 1000; i++) ;
            f1.Visible = false;
            f2.Visible = false;
            f3.Visible = false;
            f4.Visible = false;
            for (int i = 0; i < 1000; i++) ;
            f5.Visible = false;
            f6.Visible = false;
        }

        private void MessageBoX_Load(object sender, EventArgs e)
        {
            
        }
    }
}
