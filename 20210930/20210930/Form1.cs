using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210930
{
    public partial class negyzetgyok : Form
    {
        public negyzetgyok()
        {
            InitializeComponent();
        }

        private void Negyzetgyok_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int szam = int.Parse(textBox1.Text);
            textBox2.Text = Convert.ToString(Math.Round(Math.Sqrt(szam), 4));
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
