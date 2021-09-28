using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210923
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.TopCenter;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleRight;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.ToLower();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.ToUpper();
        }
    }
}
